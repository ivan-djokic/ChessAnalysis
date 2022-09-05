// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using ChessAnalysis.Properties;
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
			m_collection.AddRange(panel.Selection);
		}

		private void btnLoadFile_Click(object sender, EventArgs e)
		{
			using var fileDialog = new XtraOpenFileDialog
			{
				Filter = Constants.DIALOG_FILTER,
				InitialDirectory = Options.Instance.LastInputDirectory,
				StartPosition = FormStartPosition.CenterParent
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
				1 => Messanger.ShowError(this, string.Format(Resources.ErrorOccurred, errors.First().Message, errors.First().Line), MessageBoxButtons.YesNo),
				_ => Messanger.ShowErrorList(this, errors)
			};
		}

		private DataCollection CreateCollection(List<string> lines, out IEnumerable<Error> errorList)
		{
			var result = new Data[lines.Count];
			var errors = new Error[lines.Count];

			// Show Progress form to avoid other actions which can cause bad thread concurrency
			ProgressForm<string>.ShowProgress(this, lines, i =>
			{
				try
				{
					var data = Parser.Parse(lines[i]);

					// Validate ID uniquess in current collection
					result.ValidateIdUniqueness(data.Id);

					// Validate ID uniquess in already loaded collections in Add data from file form
					panel.Collection.ValidateIdUniqueness(data.Id);

					// Validate ID uniquess in already loaded collections in Main form
					m_collection.ValidateIdUniqueness(data.Id);

					result[i] = data;
				}
				catch (Exception ex)
				{
					errors[i] = new Error(lines[i], ex.Message);
				}
			});

			// Trim collections to contain only non-null elements
			errorList = errors.RemoveNullValues();
			return new DataCollection(result.RemoveNullValues());
		}

		private void LoadFromFile(string fileName)
		{
			var collection = CreateCollection(File.ReadLines(fileName).ToList(), out var errors);

			if (!CanAdd(errors))
			{
				FileHelper.OpenFile(fileName);
				return;
			}

			panel.Collection.AddRange(collection);
		}
	}
}
