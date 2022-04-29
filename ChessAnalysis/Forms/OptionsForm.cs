using System.ComponentModel;
using ChessAnalysis.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class OptionsForm : XtraForm
	{
		public OptionsForm()
		{
			InitializeComponent();
			InitNavigation();
		}

        protected override void OnClosing(CancelEventArgs e)
        {
			base.OnClosing(e);
			Options.Instance.Save();
		}

        private void btnDefaults_Click(object sender, EventArgs e)
		{
			Options.Instance.SetDefaults();
		}

		private void InitNavigation()
        {
            navigation.SelectedElement = itemGeneral;
            navigation.SelectedElementChanged += navigation_SelectedElementChanged;
        }

		private void navigation_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
		{
            if (e.Element == itemGeneral)
            {
                navigationFrame.SelectedPage = pageGeneral;
                return;
            }

            navigationFrame.SelectedPage = pageBoard;
        }
	}
}