using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class MainPanel : XtraUserControl
    {
        private float m_ratio;

        public MainPanel()
        {
            InitializeComponent();
            grid.FocusedRowChanged += grid_FocusedRowChanged;
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (m_ratio == 0)
            {
                splitContainerControl_SplitterMoved(new object(), EventArgs.Empty);
            }

            splitContainerControl.SplitterPosition = (int)(splitContainerControl.Width / m_ratio);
        }

        private void grid_FocusedRowChanged(Data data)
        {
            board.Reinitialize(data);
        }

        private void splitContainerControl_SplitterMoved(object sender, EventArgs e)
        {
            m_ratio = (float)splitContainerControl.Width / splitContainerControl.SplitterPosition;
        }
    }
}
