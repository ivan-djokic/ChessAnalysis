// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Classes;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class EditForm : XtraForm
	{
		private readonly DataCollection m_collection;
		private readonly int m_editIndex;

		public EditForm(DataCollection collection, int editIndex)
		{
			InitializeComponent();
			dataInput.Input = collection[editIndex].ToString();

			m_collection = collection;
			m_editIndex = editIndex;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			var data = dataInput.ParseInput(m_collection, m_collection[m_editIndex]);

			if (data != null)
			{
				m_collection[m_editIndex] = data;
				Close();
			}
		}

		private void EditForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}
	}
}
