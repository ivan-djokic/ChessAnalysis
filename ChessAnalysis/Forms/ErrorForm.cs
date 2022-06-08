using ChessAnalysis.Models;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class ErrorForm : XtraForm
	{
		public ErrorForm(IEnumerable<Error> errors)
		{
			InitializeComponent();
			grid.SetDataSource(errors);
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
			Sound.Play(Sounds.Error);
		}
	}
}