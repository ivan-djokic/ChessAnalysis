// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using System.ComponentModel;
using ChessAnalysis.Models;
using ChessAnalysis.Utils;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace ChessAnalysis.Classes
{
	public class DataGridHelper
	{
		private readonly GridView m_gridView;
		private readonly List<Data> m_hiddenSelection = new();
		private bool m_isSelectAllClicked;
		private DataCollection m_previousSelection = new();

		public DataGridHelper(GridView gridView)
		{
			m_gridView = gridView;

			m_gridView.ColumnFilterChanged += UpdateHiddenSelection;
			m_gridView.FilterEditorCreated += UpdateHiddenSelection;
			m_gridView.MouseDown += CheckIsSelectAllClicked;
			m_gridView.SelectionChanged += RefreshPreviousSelection;
		}

		public void CheckIsSelectAllClicked(object? sender, MouseEventArgs e)
		{
			var info = m_gridView.CalcHitInfo(e.Location);

			if (e.Button != MouseButtons.Left || info?.Column == null)
			{
				m_isSelectAllClicked = false;
				return;
			}

			m_isSelectAllClicked = info.Column.Name == Constants.SELECTOR_COLUMN && info.HitTest == GridHitTest.Column;
		}

		public DataCollection GetDataSelection()
		{
			var selection = new DataCollection();

			foreach (var rowHandle in m_gridView.GetSelectedRows())
			{
				if (m_gridView.GetRow(rowHandle) is Data data)
				{
					selection.Add(data);
				}
			}

			return selection;
		}

		private void RefreshPreviousSelection(object sender, SelectionChangedEventArgs e)
		{
			var selection = GetDataSelection();

			if (selection.Count < m_previousSelection.Count && e.Action != CollectionChangeAction.Remove && !m_isSelectAllClicked)
			{
				// Some items are lost - previous selection will be updated in SelectHiddenItems method
				return;
			}

			m_isSelectAllClicked = false;
			m_previousSelection = selection;
		}

		private void UpdateHiddenSelection(object? sender, EventArgs e)
		{
			var p = m_previousSelection;

			m_gridView.SelectionChanged -= RefreshPreviousSelection;
			m_hiddenSelection.AddRange(m_previousSelection.Except(GetDataSelection()).Except(m_hiddenSelection));

			for (var i = m_hiddenSelection.Count - 1; i >= 0; i--)
			{
				var rowHandle = m_gridView.FindRow(m_hiddenSelection[i]);

				if (rowHandle < 0)
				{
					continue;
				}

				m_hiddenSelection.RemoveAt(i);
				m_gridView.SelectRow(rowHandle);
			}

			m_previousSelection = GetDataSelection();
			m_gridView.SelectionChanged += RefreshPreviousSelection;
		}
	}
}
