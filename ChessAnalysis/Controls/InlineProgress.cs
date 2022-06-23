using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
	public partial class InlineProgress : XtraUserControl
	{
		public InlineProgress()
		{
			InitializeComponent();
		}

		public bool Stop { get; private set; }

		public void NextStep()
		{
			if (InvokeRequired)
			{
				Invoke(new Action(NextStep));
				return;
			}

			progressBar.Position++;
		}

		public void InitializeSteps(int stepsCount)
		{
			progressBar.Properties.Maximum = stepsCount;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			Stop = true;
		}
	}
}
