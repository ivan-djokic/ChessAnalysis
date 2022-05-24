using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace ChessAnalysis.Controls
{
    public partial class DataGrid : XtraUserControl
    {
        private List<Data> m_dataSource = new();

        public DataGrid()
        {
            InitializeComponent();
        }

        public Action<Data> FocusedRowChanged;
        public Action<int> RowCountChanged;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            m_dataSource.AddRange(new List<Data>
            {
                Parser.Parse("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq - 0 1 bm e4; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2001 17:31:05\" \"King's pawn opening\" \"Sicilian defense\""),
                Parser.Parse("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2 bm Ra8; id \"YAZ.19\"; c0 \"Djokic - Mitar\" \"22.05.2022 14:20:00\" \"Otvaranje\" \"Sicilian defense\""),
                Parser.Parse("r1bq1rk1/ppp1n1pp/1b3p2/1B1p4/3pP2B/1N1P4/PPP2PPP/R2Q1RK1 b KQkq - 1 3 bm Nf3; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2013 17:12:55\" \"Queen gambit\" \"Odbrana\""),
                Parser.Parse("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq - 0 1 bm Qd1; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2002 17:31:05\" \"King's pawn opening\" \"Sicilian defense\""),
                Parser.Parse("rnbqkbnr/pppp1ppp/8/4p3/4P3/8/PPPP1PPP/RNBQKBNR w KQkq e6 0 2 bm dxe5; id \"YAZ.19\"; c0 \"Djokic - Mitar\" \"22.05.2022 14:20:00\" \"Otvaranje\" \"Sicilian defense\""),
                Parser.Parse("r2q1rk1/ppp3pp/1b2bp2/3n4/2Bp3B/1N1P4/PPP2PPP/R2Q1RK1 w - - 2 13 bm B2xe6+; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2021 17:12:55\" \"Queen gambit\" \"Odbrana\"")
            });

            gridControl.DataSource = m_dataSource;
            RowCountChanged?.Invoke(m_dataSource.Count);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRowsCount > 0)
            {
                XtraMessageBox.Show(gridView.LastSelectedHandle.ToString());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            gridView.DeleteSelectedRows();
            RowCountChanged?.Invoke(m_dataSource.Count);
        }

        private void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (gridView.FocusedRowHandle >= 0 && m_dataSource[gridView.FocusedRowHandle] is Data row)
            {
                FocusedRowChanged?.Invoke(row);
            }
        }
    }
}
