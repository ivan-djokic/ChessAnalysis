using System.Collections.ObjectModel;
using System.Collections.Specialized;
using ChessAnalysis.Models;

namespace ChessAnalysis.Classes
{
	public class DataCollection : ObservableCollection<Data>
	{
		private bool m_updating;

		public DataCollection()
		{
		}

		public DataCollection(IEnumerable<Data> collection)
			: base(collection)
		{
		}

		public void AddRange(IEnumerable<Data> collection)
		{
			m_updating = true;

			foreach (var item in collection)
			{
				Add(item);
			}

			m_updating = false;
			OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, collection));
		}

		public void RemoveRange(IList<int> collection)
		{
			m_updating = true;

			for (var i = collection.Count - 1; i >= 0; i--)
			{
				RemoveAt(collection[i]);
			}

			m_updating = false;
			OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, collection));
		}

		public override string ToString()
		{
			return string.Join(Environment.NewLine, this.Select(data => data.ToString()));
		}

		protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			if (!m_updating)
			{
				base.OnCollectionChanged(e);
			}
		}
	}
}
