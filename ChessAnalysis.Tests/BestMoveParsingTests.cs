// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using System.Drawing;
using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
	[TestClass]
	public class BestMoveParsingTests
	{
		private static char[][] m_fen = new[]
		{
			new[] { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' },
			new[] { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
			new char[8], new char[8], new char[8], new char[8],
			new[] { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
			new[] { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }
		};

		[TestMethod]
		public void TestInvalidInputs()
		{
			ProcessInvalidInput(string.Empty, true);
			ProcessInvalidInput("e", false);
			ProcessInvalidInput("R2xg2$", true);
			ProcessInvalidInput("Bx3b", false);
			ProcessInvalidInput("qxa8+", false);
			ProcessInvalidInput("Nxi6#", false);
			ProcessInvalidInput("ab1", false);
			ProcessInvalidInput("Sb1", false);
			ProcessInvalidInput("xe3", true);
			ProcessInvalidInput("Pe3", true);
			ProcessInvalidInput("pe3", false);
			ProcessInvalidInput("BGxb3", true);
			ProcessInvalidInput("R9xb3", true);
			ProcessInvalidInput("R21xg2+", false);

			ProcessInvalidInput("e1=", true);
			ProcessInvalidInput("=Q", true);
			ProcessInvalidInput("b1=J", false);
			ProcessInvalidInput("i1=R", true);
			ProcessInvalidInput("c2=R", false);
			ProcessInvalidInput("a1=Q", true);
			ProcessInvalidInput("a1=P", false);
			ProcessInvalidInput("h8=K", true);

			ProcessInvalidInput("O-", true);
			ProcessInvalidInput("O-O-Ok", false);
			ProcessInvalidInput("O-O-O-O", true);
		}

		private static void ProcessInvalidInput(string input, bool isWhite)
		{
			var failed = false;

			try
			{
				BestMovePointsParser.Parse(input, m_fen, isWhite, string.Empty);
			}
			catch
			{
				failed = true;
			}

			Assert.IsTrue(failed);
		}
	}
}
