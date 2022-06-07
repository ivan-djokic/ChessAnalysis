using ChessAnalysis.Classes;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class AddForm : XtraForm
	{
		private readonly DataCollection m_collection;

		public AddForm(DataCollection collection)
		{
			InitializeComponent();
			m_collection = collection;
		}

        private void btnAdd_Click(object sender, EventArgs e)
        {
			var data = dataInput.ParseInput(m_collection);

			if (data != null)
            {
				m_collection.Add(data);
            }
        }
    }
}