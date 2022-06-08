using System.Net;
using System.Net.Mail;
using ChessAnalysis.Classes;
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
                Alert.Error(this, "Error in Mail sender or receiver configuration. Change configuration parameters and try again", MessageBoxButtons.OK);
            }
        }
    }
}