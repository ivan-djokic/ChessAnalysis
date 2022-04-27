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

        public void Save(string fileName)
        {
            pictureBox.BackgroundImage?.Save(fileName);
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
                pictureBox.Location = new Point((Width - Height) / 2, 0);
                pictureBox.Size = new Size(Height, Height);
                return;
            }

            pictureBox.Location = new Point(0, (Height - Width) / 2);
            pictureBox.Size = new Size(Width, Width);
        }
    }
}
