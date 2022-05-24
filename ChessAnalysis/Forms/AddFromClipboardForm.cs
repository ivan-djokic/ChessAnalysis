using System.ComponentModel;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class AddFromClipboardForm : XtraForm
	{
		public AddFromClipboardForm()
		{
			InitializeComponent();
		}

        protected override void OnClosing(CancelEventArgs e)
        {
			
		}

        private void btnDefaults_Click(object sender, EventArgs e)
		{
			
		}

		private void navigation_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
		{

        }
	}
}