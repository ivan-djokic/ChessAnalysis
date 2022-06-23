using System.Collections.Specialized;
using ChessAnalysis.Classes;
using ChessAnalysis.Forms;
using ChessAnalysis.Models;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace ChessAnalysis.Controls
{
	public partial class DataGrid : XtraUserControl
	{
		private LayoutVisibility m_controlsVisibility;

		public DataGrid()
		{
			InitializeComponent();

			gridControl.DataSource = new DataCollection();
			Collection.CollectionChanged += CollectionChanged;
		}

		public Action<Data>? FocusedRowChanged;

		public Action<int>? RowCountChanged;

		public DataCollection Collection
		{
			get => (DataCollection)gridControl.DataSource;
		}

		public bool ShowOnlyGrid
		{
			get => m_controlsVisibility == LayoutVisibility.Never;
			set
			{
				if (ShowOnlyGrid != value)
				{
					m_controlsVisibility = value ? LayoutVisibility.Never : LayoutVisibility.Always;
					ChangeControlsVisibility();
				}
			}
		}

		public DataCollection GetSelection()
		{
			var selection = new DataCollection();
			
			foreach (var rowHandle in gridView.GetSelectedRows())
			{
				if (gridView.GetRow(rowHandle) is Data row)
				{
					selection.Add(row);
				}
			}

			return selection;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (gridView.FocusedRowHandle >= 0)
			{
				using var editForm = new EditForm(Collection, gridView.FocusedRowHandle);
				editForm.ShowDialog(this);
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			Collection.RemoveRange(gridView.GetSelectedRows());
		}

		private void btnRestore_Click(object sender, EventArgs e)
		{
			gridView.RestoreLayout();
		}

		private void ChangeControlsVisibility()
		{
			lciRestore.Visibility = m_controlsVisibility;
			lciEdit.Visibility = m_controlsVisibility;
			lciRemove.Visibility = m_controlsVisibility;
		}

		private void CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
		{
			RaiseNotification(e);

			if (e.Action == NotifyCollectionChangedAction.Replace)
			{
				gridView_FocusedRowChanged(new object(), EventArgs.Empty);
				return;
			}

			gridView.RefreshData(e.Action == NotifyCollectionChangedAction.Add);
			RowCountChanged?.Invoke(Collection.Count);
		}

		private void gridView_FocusedRowChanged(object sender, EventArgs e)
		{
			if (gridView.FocusedRowHandle >= 0)
			{
				Sound.Play(Sounds.Piece);
				FocusedRowChanged?.Invoke(Collection[gridView.FocusedRowHandle]);
			}
		}

		private void RaiseNotification(NotifyCollectionChangedEventArgs e)
		{
			if (ShowOnlyGrid)
			{
				return;
			}

			switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
					if (e.NewItems != null && e.NewItems.Count > 0 && e.NewItems[0] is DataCollection collection && collection.Count > 0)
					{
						Notification.Notify?.Invoke(string.Format(Resources.NotifyAdd, collection.Count));
					}

					break;

				case NotifyCollectionChangedAction.Remove:
					if (e.OldItems != null && e.OldItems.Count > 0 && e.OldItems[0] is int[] array && array.Length > 0)
					{
						Notification.Notify?.Invoke(string.Format(Resources.NotifyRemove, array.Length));
					}

					break;

				case NotifyCollectionChangedAction.Replace:
					Notification.Notify?.Invoke(string.Format(Resources.NotifyEdit, gridView.FocusedRowHandle));
					break;
			}

			Notification.Notify?.Invoke(string.Empty);
		}
	}
}
