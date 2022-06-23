using ChessAnalysis.Classes;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class MailForm : XtraForm
	{
        private readonly DataCollection m_collection;

		public MailForm(DataCollection collection)
		{
			InitializeComponent();
            m_collection = collection;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                mail.Send(m_collection);
                Close();
            }
            catch
            {
                ErrorMessage.Show(this, Resources.MailError, MessageBoxButtons.OK);
            }
        }
    }
}