using System.Collections.Specialized;
using ChessAnalysis.Classes;
using ChessAnalysis.Forms;
using ChessAnalysis.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace ChessAnalysis.Controls
{
    public partial class DataGrid : XtraUserControl
    {
        private LayoutVisibility m_controlsVisibility;

        public DataGrid()
        {
            InitializeComponent();
            Collection.CollectionChanged += CollectionChanged;
        }

        public Action<Data>? FocusedRowChanged;

        public Action<int>? RowCountChanged;

        public DataCollection Collection
        {
            get => (DataCollection)gridControl.DataSource;
        }

        public bool ShowOnlyGrid
        {
            get => m_controlsVisibility == LayoutVisibility.Never;
            set
            {
                if (ShowOnlyGrid != value)
                {
                    m_controlsVisibility = value ? LayoutVisibility.Never : LayoutVisibility.Always;
                    ChangeControlsVisibility();
                }
            }
        }

        public DataCollection GetSelection()
        {
            var selection = new DataCollection();
            
            foreach (var rowHandle in gridView.GetSelectedRows())
            {
                if (gridView.GetRow(rowHandle) is Data row)
                {
                    selection.Add(row);
                }
            }

            return selection;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Collection.AddRange(new DataCollection(new List<Data>
            {
                Parser.Parse("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq - 0 1 bm e4; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2001 17:31:05\" \"King's pawn opening\" \"Sicilian defense\""),
                Parser.Parse("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2 bm Ra8; id \"YAZ.19\"; c0 \"Djokic - Mitar\" \"22.05.2022 14:20:00\" \"Otvaranje\" \"Sicilian defense\""),
                Parser.Parse("r1bq1rk1/ppp1n1pp/1b3p2/1B1p4/3pP2B/1N1P4/PPP2PPP/R2Q1RK1 b KQkq - 1 3 bm Nf3; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2013 17:12:55\" \"Queen gambit\" \"Odbrana\""),
                Parser.Parse("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq - 0 4 bm Qd1; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2002 17:31:05\" \"King's pawn opening\" \"Sicilian defense\""),
                Parser.Parse("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 5 bm dxe5; id \"YAZ.19\"; c0 \"Djokic - Mitar\" \"22.05.2022 14:20:00\" \"Otvaranje\" \"Sicilian defense\""),
                Parser.Parse("r2q1rk1/ppp3pp/1b2bp2/3n4/2Bp3B/1N1P4/PPP2PPP/R2Q1RK1 w - - 2 6 bm B2xe6+; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2021 17:12:55\" \"Queen gambit\" \"Odbrana\"")
            }));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var editForm = new EditForm(Collection, gridView.LastSelectedHandle);
            editForm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Collection.RemoveRange(gridView.GetSelectedRows());
        }

        private void ChangeControlsVisibility()
        {
            lciAdd.Visibility = m_controlsVisibility;
            lciEdit.Visibility = m_controlsVisibility;
            lciRemove.Visibility = m_controlsVisibility;
        }

        private void CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            RaiseNotification(e);

            if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                gridView_FocusedRowChanged(new object(), EventArgs.Empty);
                return;
            }

            gridView.RefreshData(e.Action == NotifyCollectionChangedAction.Add);
            RowCountChanged?.Invoke(Collection.Count);
        }

        private void gridView_FocusedRowChanged(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle >= 0)
            {
                FocusedRowChanged?.Invoke(Collection[gridView.FocusedRowHandle]);
            }
        }

        private void RaiseNotification(NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems != null && e.NewItems.Count > 0 && e.NewItems[0] is DataCollection collection && collection.Count > 0)
                    {
                        Notification.Notify?.Invoke($"{collection.Count} row{(collection.Count == 1 ? " was" : "s were")} added");
                    }
                    
                    break;

                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems != null && e.OldItems.Count > 0 && e.OldItems[0] is int[] array && array.Length > 0)
                    {
                        Notification.Notify?.Invoke($"{array.Length} row{(array.Length == 1 ? " was" : "s were")} removed");
                    }
                    
                    break;

                case NotifyCollectionChangedAction.Replace:
                    Notification.Notify?.Invoke($"{gridView.FocusedRowHandle}. row was edited");
                    break;
            }
        }
    }
}
