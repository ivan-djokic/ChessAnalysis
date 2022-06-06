using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class MainPanel : XtraUserControl
    {
        private double m_ratio = 2.6;

        public MainPanel()
        {
            InitializeComponent();
            Resize += (obj, e) => 

            splitContainerControl.SplitterPosition = (int)(splitContainerControl.Width / m_ratio);

            splitContainerControl.SplitterMoved += (obj, e) => m_ratio = (double)splitContainerControl.Width / splitContainerControl.SplitterPosition;
        }

        public event Action<int> RowCountChanged
        {
            add => grid.RowCountChanged += value;
            remove => grid.RowCountChanged -= value;
        }

        public DataCollection Collection
        {
            get => grid.Collection;
        }

        public bool ShowOnlyMainControls
        {
            get => board.ShowOnlyBoard && grid.ShowOnlyGrid;
            set => board.ShowOnlyBoard = grid.ShowOnlyGrid = value;
        }

        public DataCollection GetSelection()
        {
            return grid.GetSelection();
        }

        public void TakeSnapshot()
        {
            board.TakeSnapshot();
        }

        private void grid_FocusedRowChanged(Data data)
        {
            board.Data = data;
        }
    }
}
