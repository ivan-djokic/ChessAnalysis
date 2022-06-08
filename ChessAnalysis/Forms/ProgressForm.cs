using DevExpress.XtraEditors;
using System.ComponentModel;

namespace ChessAnalysis.Forms
{
	public partial class ProgressForm<T> : XtraForm
	{
		private readonly Action<int> m_action;
		private readonly IList<T> m_collection;

		private ProgressForm(IList<T> collection, Action<int> action)
		{
			InitializeComponent();

			inlineProgress.InitializeSteps(collection.Count);
			m_collection = collection;
			m_action = action;
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
				m_action.Invoke(i);
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
	}
}
