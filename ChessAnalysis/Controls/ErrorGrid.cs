// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

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

		public void Reinitialize(IEnumerable<Error> dataSource)
		{
			gridControl.DataSource = dataSource;
		}
	}
}
