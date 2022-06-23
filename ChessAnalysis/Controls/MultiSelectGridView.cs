using System.IO;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ChessAnalysis.Controls
{
	public class MultiSelectGridView : GridView
	{
		private readonly MemoryStream m_layoutStream = new();

		public MultiSelectGridView()
		{
			OptionsMenu.EnableColumnMenu = false;
			OptionsMenu.EnableGroupPanelMenu = false;
			OptionsNavigation.AutoFocusNewRow = true;
			OptionsSelection.CheckBoxSelectorColumnWidth = 28;
			OptionsSelection.EnableAppearanceFocusedCell = false;
			OptionsSelection.MultiSelect = true;
			OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
			OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;

			SaveLayoutToStream(m_layoutStream);
		}

		protected override bool AllowFixedCheckboxSelectorColumn
		{
			get => true;
		}

		public void RefreshData(bool refreshSelection)
		{
			var selection = refreshSelection ? GetSelectedRows() : Array.Empty<int>();
			base.RefreshData();
			ClearSelection();

			foreach (var row in selection)
			{
				SelectRow(row - 1);
			}
		}

		public void RestoreLayout()
		{
			m_layoutStream.Position = 0;
			RestoreLayoutFromStream(m_layoutStream);
		}

		protected override void CreateCheckboxSelectorColumn()
		{
			base.CreateCheckboxSelectorColumn();
			CheckboxSelectorColumn.Fixed = FixedStyle.Left;
		}

		protected override void OnBeginUpdate()
		{
			base.OnBeginUpdate();
			RowStyle += PaintFocusedRow;
		}

		private void PaintFocusedRow(object sender, RowStyleEventArgs e)
		{
			if (e.RowHandle == FocusedRowHandle)
			{
				e.Appearance.Assign(PaintAppearance.SelectedRow);
			}
		}
	}
}
