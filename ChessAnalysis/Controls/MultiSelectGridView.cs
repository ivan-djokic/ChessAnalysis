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
		}

		public new int FocusedRowHandle
		{
			get => GetDataSourceRowIndex(base.FocusedRowHandle);
			set => base.FocusedRowHandle = value;
		}

		protected override bool AllowFixedCheckboxSelectorColumn
		{
			get => true;
		}

		public void RefreshData(bool refreshSelection = false)
		{
			var selection = refreshSelection ? GetSelectedRows() : Array.Empty<int>();
			base.RefreshData();
			ClearSelection();

			foreach (var row in selection)
			{
				SelectRow(row - 1);
			}
		}

		public void RefreshGrouping()
		{
			var count = 0;
			var groupColumns = new int[Columns.Count];

			for (var i = 0; i < Columns.Count; i++)
			{
				if (Columns[i].GroupIndex < 0)
				{
					continue;
				}

				groupColumns[Columns[i].GroupIndex] = i;
				count++;
			}

			ClearGrouping();

			for (var i = 0; i < count; i++)
			{
				Columns[groupColumns[i]].Group();
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

		protected override void OnEndInit()
		{
			base.OnEndInit();

			RowStyle += PaintFocusedRow;
			SaveLayoutToStream(m_layoutStream);
		}

		private void PaintFocusedRow(object sender, RowStyleEventArgs e)
		{
			if (e.RowHandle == FocusedRowHandle && !IsGroupRow(e.RowHandle))
			{
				e.Appearance.Assign(PaintAppearance.SelectedRow);
			}
		}
	}
}
