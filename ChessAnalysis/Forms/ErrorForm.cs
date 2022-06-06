using System.Media;
using ChessAnalysis.Models;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class ErrorForm : XtraForm
	{
		private ErrorForm(IEnumerable<Error> errors)
		{
			InitializeComponent();
			grid.SetDataSource(errors);
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
			SystemSounds.Hand.Play();
		}

        public static DialogResult Show(IWin32Window owner, IEnumerable<Error> errors)
		{
			using var form = new ErrorForm(errors);
			return form.ShowDialog(owner);
		}
	}
}