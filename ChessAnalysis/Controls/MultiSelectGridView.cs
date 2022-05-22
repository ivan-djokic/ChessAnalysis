﻿using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ChessAnalysis.Controls
{
    public class MultiSelectGridView : GridView
    {
        public MultiSelectGridView()
        {
            OptionsNavigation.AutoFocusNewRow = true;
            OptionsSelection.CheckBoxSelectorColumnWidth = 28;
            OptionsSelection.EnableAppearanceFocusedCell = false;
            OptionsSelection.MultiSelect = true;
            OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
        }

        public int LastSelectedHandle { get; private set; }

        protected override bool AllowFixedCheckboxSelectorColumn
        {
            get => true;
        }

        protected override void CreateCheckboxSelectorColumn()
        {
            base.CreateCheckboxSelectorColumn();
            CheckboxSelectorColumn.Fixed = FixedStyle.Left;
        }

        protected override void OnBeginUpdate()
        {
            base.OnBeginUpdate();

            FocusRectStyle = DrawFocusRectStyle.RowFocus;
            RowStyle += new RowStyleEventHandler(PaintFocusedRow);
            SelectionChanged += new SelectionChangedEventHandler(SetLastSelectedHandle);
        }

        private void PaintFocusedRow(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == FocusedRowHandle)
            {
                e.Appearance.Assign(PaintAppearance.SelectedRow);
            }
        }

        private void SetLastSelectedHandle(object sender, SelectionChangedEventArgs e)
        {
            LastSelectedHandle = FocusedRowHandle;
        }
    }
}
