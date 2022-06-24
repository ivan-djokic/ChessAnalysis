using ChessAnalysis.Classes;
using ChessAnalysis.Controls;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class SelectDataAmountForm : XtraForm
	{
		private SelectDataAmountForm()
		{
			InitializeComponent();
		}

		private bool OnlySelected { get; set; }

		public static DataCollection? GetDataCollection(IWin32Window owner, MainPanel panel, ref bool? onlySelected)
		{
			var selection = panel.Selection;

			if (onlySelected == false || !selection.Any() || selection.Count == panel.Collection.Count)
			{
				return panel.Collection;
			}

			if (onlySelected == true)
			{
				return selection;
			}

			using var selectDataAmountForm = new SelectDataAmountForm();
			
			if (selectDataAmountForm.ShowDialog(owner) != DialogResult.OK)
			{
				return null;
			}

			if (selectDataAmountForm.chxDontShowAgain.Checked)
			{
				onlySelected = selectDataAmountForm.OnlySelected;
			}

			return selectDataAmountForm.OnlySelected ? selection : panel.Collection;
		}

		private void selection_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
		{
			OnlySelected = e.Element == itemSelectedOnly;
			DialogResult = DialogResult.OK;
		}
	}
}
