// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
	public partial class CenteredImageBox : XtraUserControl
	{
		public CenteredImageBox()
		{
			InitializeComponent();
		}

		public Image Image
		{
			get => pictureBox.BackgroundImage;
			set => pictureBox.BackgroundImage = value;
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			Centralize();
		}

		private void Centralize()
		{
			if (Width > Height)
			{
				// Centralize by X axis
				pictureBox.Location = new Point((Width - Height) / 2, 0);
				pictureBox.Size = new Size(Height, Height);
				return;
			}

			// Centralize by Y axis
			pictureBox.Location = new Point(0, (Height - Width) / 2);
			pictureBox.Size = new Size(Width, Width);
		}
	}
}
