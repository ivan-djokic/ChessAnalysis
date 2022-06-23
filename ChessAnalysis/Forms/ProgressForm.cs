using System.ComponentModel;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class ProgressForm<T> : XtraForm
	{
		private readonly IList<T> m_collection;
		private readonly Action<int> m_work;

		private ProgressForm(IList<T> collection, Action<int> work)
		{
			InitializeComponent();
			SetResolution();

			inlineProgress.InitializeSteps(collection.Count);
			m_collection = collection;
			m_work = work;
		}

		public static void ShowProgress(IWin32Window owner, IList<T> collection, Action<int> action)
		{
			using var form = new ProgressForm<T>(collection, action);
			form.ShowDialog(owner);
		}

		private void DoWork(object? sender, EventArgs e)
		{
			Parallel.For(0, m_collection.Count, (i, state) =>
			{
				Thread.Sleep(1);
				m_work.Invoke(i);
				inlineProgress.NextStep();

				if (inlineProgress.Stop)
				{
					state.Break();
				}
			});
		}

		private void RunWorkerCompleted(object? sender, EventArgs e)
		{
			Close();
		}

		private void ProgressForm_Shown(object sender, EventArgs e)
		{
			using var worker = new BackgroundWorker();
			worker.DoWork += DoWork;
			worker.RunWorkerCompleted += RunWorkerCompleted;
			worker.RunWorkerAsync();
		}

		private void SetResolution()
		{
			if (ScreenHelper.IsHD)
			{
				ClientSize = new Size(428, 72);
			}
		}
	}
}
