using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class AddFromFileForm : XtraForm
	{
		private readonly DataCollection m_collection;

		public AddFromFileForm(DataCollection collection)
		{
			InitializeComponent();
			m_collection = collection;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			m_collection.AddRange(panel.GetSelection());
		}

		private void btnLoadFile_Click(object sender, EventArgs e)
		{
			using var fileDialog = new XtraOpenFileDialog
			{
				Filter = Constants.DIALOG_FILTER,
				InitialDirectory = Options.Instance.LastInputDirectory
			};

			if (fileDialog.ShowDialog(this) == DialogResult.OK)
			{
				LoadFromFile(fileDialog.FileName);

				Options.Instance.LastInputDirectory = FileHelper.GetDirectoryName(fileDialog.FileName);
				Options.Instance.Save();
			}
		}

		private bool CanAdd(IEnumerable<Error> errors)
		{
			return errors.Count() switch
			{
				0 => true,
				1 => ErrorMessage.Show(this, $"{errors.First().Message} in line {errors.First().Line}\nDo you want to continue?"),
				_ => ErrorMessage.ShowList(this, errors)
			};
		}

		private DataCollection CreateCollection(IList<string> lines, out IEnumerable<Error> errorList)
		{
			var result = new Data[lines.Count];
			var errors = new Error[lines.Count];

			ProgressForm<string>.ShowProgress(this, lines, i =>
			{
				try
				{
					var data = Parser.Parse(lines[i]);

					result.ValidateIdUniqueness(data.Id);
					panel.Collection.ValidateIdUniqueness(data.Id);
					m_collection.ValidateIdUniqueness(data.Id);

					result[i] = data;
				}
				catch (Exception ex)
				{
					errors[i] = new Error(lines[i], ex.Message);
				}
			});

			errorList = errors.RemoveNullValues();
			return new DataCollection(result.RemoveNullValues());
		}

		private void LoadFromFile(string fileName)
		{
			var collection = CreateCollection(File.ReadLines(fileName).ToList(), out var errors);

			if (CanAdd(errors))
			{
				panel.Collection.AddRange(collection);
			}
		}
	}
}
