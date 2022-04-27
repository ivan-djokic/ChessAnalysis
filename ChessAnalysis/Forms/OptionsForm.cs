// -----------------------------------------------
// © 2019 Quest Software Inc. ALL RIGHTS RESERVED.
// -----------------------------------------------

using ChessAnalysis.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace ChessAnalysis.Forms
{
	public partial class OptionsForm : XtraForm
	{
		private Options? m_oldOptions;

		public OptionsForm()
		{
			InitializeComponent();
			navigation.SelectedElement = itemGeneral;
		}

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

			if (DialogResult == DialogResult.OK)
			{
				SaveOptions();
				return;
			}

			m_oldOptions?.CopyTo(Options.Instance);
		}

        private void btnDefaults_Click(object sender, EventArgs e)
		{
			m_oldOptions = Options.Instance.Clone();
			Options.Instance.SetDefaults();
			Reinitialize();
		}

		private void navigation_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
		{
			if (e.Element == itemGeneral)
			{
				navigationFrame.SelectedPage = navigationGeneral;
			}
			else if (e.Element == itemShortcuts)
			{
				navigationFrame.SelectedPage = navigationShortcuts;
            }
		}

		private void Reinitialize()
		{
			generalTab.Reinitialize();
			shortcutsTab.Reinitialize();
		}

		private void SaveOptions()
        {
			generalTab.SaveOptions();
			//shortcutsTab.SaveOptions();
			Options.Instance.Save();
		}
	}
}