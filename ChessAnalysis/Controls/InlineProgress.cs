// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

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

		public void InitializeSteps(int stepsCount)
		{
			progressBar.Properties.Maximum = stepsCount;
		}

		public void NextStep()
		{
			if (InvokeRequired)
			{
				Invoke(NextStep);
				return;
			}

			progressBar.Position++;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			Stop = true;
		}
	}
}
