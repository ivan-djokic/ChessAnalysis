using ChessAnalysis.Models;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class ErrorGrid : XtraUserControl
    {
        public ErrorGrid()
        {
            InitializeComponent();
        }

        public void SetDataSource(IEnumerable<Error> dataSource)
        {
            gridControl.DataSource = dataSource;
        }
    }
}
