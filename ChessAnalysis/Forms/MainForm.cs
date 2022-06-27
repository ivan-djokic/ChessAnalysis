using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class MainForm : RibbonForm
	{
		private bool? m_onlySelectedMail;
		private bool? m_onlySelectedSave;
		private string m_savedFile = string.Empty;

		public MainForm()
		{
			Theme.ApplyTheme();
			InitializeComponent();

			panel.RowCountChanged += RowCountChanged;
			Notification.Notify += SetNotification;
		}

		protected override void OnLoad(EventArgs e)
		{
			Sound.Play(Sounds.Start);
			base.OnLoad(e);
		}

		private void btnAdd_ItemClick(object sender, EventArgs e)
		{
			using var addForm = new AddForm(panel.Collection);
			addForm.ShowDialog(this);
		}

		private void btnAddFromFile_ItemClick(object sender, EventArgs e)
		{
			using var addFromFileForm = new AddFromFileForm(panel.Collection);
			addFromFileForm.ShowDialog(this);
		}

		private void btnMail_ItemClick(object sender, EventArgs e)
		{
			var dataCollection = SelectDataAmountForm.GetDataCollection(this, panel, ref m_onlySelectedMail);

			if (dataCollection == null)
			{
				return;
			}

			if (!dataCollection.Any())
			{
				Messanger.ShowWarning(this, Resources.NothingToSend);
				return;
			}

			using var mailForm = new MailForm(dataCollection);
			mailForm.ShowDialog(this);
		}

		private void btnOptions_ItemClick(object sender, EventArgs e)
		{
			using var optionsForm = new OptionsForm();
			optionsForm.ShowDialog(this);
		}

		private void btnSave_ItemClick(object sender, EventArgs e)
		{
			if (!File.Exists(m_savedFile))
			{
				btnSaveAs_ItemClick(new object(), EventArgs.Empty);
				return;
			}

			SaveCollection();
		}

		private void btnSaveAs_ItemClick(object sender, EventArgs e)
		{
			using var fileDialog = new XtraSaveFileDialog
			{
				Filter = Constants.DIALOG_FILTER,
				InitialDirectory = Options.Instance.LastOutputDirectory,
				StartPosition = FormStartPosition.CenterParent
			};

			if (fileDialog.ShowDialog(this) == DialogResult.OK)
			{
				m_savedFile = fileDialog.FileName;
				SaveCollection();
			}
		}

		private void btnSnapshot_ItemClick(object sender, EventArgs e)
		{
			panel.TakeSnapshot();
		}

		private void RowCountChanged(int count)
		{
			lblTotalPositions.Caption = string.Format(Resources.TotalRows, count);
		}

		private void SaveCollection()
		{
			var dataCollection = SelectDataAmountForm.GetDataCollection(this, panel, ref m_onlySelectedSave);

			if (dataCollection == null)
			{
				return;
			}

			if (!dataCollection.Any())
			{
				Messanger.ShowWarning(this, Resources.NothingToSave);
				return;
			}

			FileHelper.Save(m_savedFile, dataCollection.ToString());
			Options.Instance.LastOutputDirectory = FileHelper.GetDirectoryName(m_savedFile);
			Options.Instance.Save();

			Sound.Play(Sounds.Save);
			Text = string.Format(Resources.MainCaptionSaved, Path.GetFileNameWithoutExtension(m_savedFile));
			Notification.Notify?.Invoke(string.Format(Resources.NotifySavedFile, Path.GetFileName(m_savedFile)));
		}

		private void SetNotification(string notification)
		{
			if (string.IsNullOrEmpty(notification))
			{
				Text = string.Format(Resources.MainCaptionEdited, Path.GetFileNameWithoutExtension(m_savedFile));
				return;
			}

			lblNotification.Caption = notification;
			timer.Restart();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			timer.Stop();
			lblNotification.Caption = string.Empty;
		}
	}
}
