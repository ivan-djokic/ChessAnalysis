﻿// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace ChessAnalysis.Controls
{
	public partial class Board : XtraUserControl
	{
		private LayoutVisibility m_controlsVisibility;
		private Data m_data;
		private bool m_whiteOrientedBoard = true;

		public Board()
		{
			InitializeComponent();

			Options.BoardOptionsChanged += DrawImage;
			Reinitialize(Parser.Parse(Constants.DEFAULT_INPUT));
			lblNextPlayer.Text = string.Empty;
		}

		public bool ShowOnlyBoard
		{
			get => m_controlsVisibility == LayoutVisibility.Never;
			set
			{
				if (ShowOnlyBoard != value)
				{
					m_controlsVisibility = value ? LayoutVisibility.Never : LayoutVisibility.Always;
					ChangeControlsVisibility();
				}
			}
		}

		public void Reinitialize(Data data)
		{
			lblPlayers.Text = data.Comment.Players;
			lblResult.Text = data.Comment.Result;
			lblOpening.Text = data.Comment.Opening;
			lblDefense.Text = data.Comment.Defense;
			lblNextPlayer.Text = string.Format(Constants.NEXT_PLAYER, data.Position.NextPlayer);

			m_data = data;
			DrawImage();
		}

		public void TakeSnapshot()
		{
			try
			{
				FileHelper.CreateDirIfNotExists(Options.Instance.SnapshotDirectory);
				var fileName = SaveSnapshot(Path.Combine(Options.Instance.SnapshotDirectory, string.Format(Constants.SNAPSHOT_FILE, m_data.Id)));

				Sound.Play(Sounds.Snapshot);
				Notification.Notify?.Invoke(string.Format(Resources.NotifySnapshot, Path.GetFileName(fileName)));
			}
			catch
			{
				Messanger.ShowError(this, Resources.SnapshotError);
			}
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(m_data.ToString());
		}

		private void btnFlip_Click(object sender, EventArgs e)
		{
			m_whiteOrientedBoard = !m_whiteOrientedBoard;
			Sound.Play(Sounds.Flip);
			DrawImage();
		}

		private void ChangeControlsVisibility()
		{
			lciPlayers.Visibility = m_controlsVisibility;
			lciResult.Visibility = m_controlsVisibility;
			lciOpening.Visibility = m_controlsVisibility;
			lciDefense.Visibility = m_controlsVisibility;
			lciNextPlayer.Visibility = m_controlsVisibility;
			lciFlip.Visibility = m_controlsVisibility;
		}

		private void DrawImage()
		{
			imageBoard.Image = BoardImage.Create(this, m_data.Position, m_whiteOrientedBoard);
		}

		private string SaveSnapshot(string fileName, int tryCount = 1)
		{
			if (!File.Exists(fileName))
			{
				imageBoard.Image.Save(fileName);
				return fileName;
			}

			return SaveSnapshot(Path.Combine(Options.Instance.SnapshotDirectory, string.Format(Constants.SNAPSHOT_FILE_DUPLICATE, m_data.Id, tryCount)), tryCount + 1);
		}
	}
}
