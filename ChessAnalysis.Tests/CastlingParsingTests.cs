using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
	[TestClass]
	public class CastlingParsingTests
	{
		[TestMethod]
		public void TestInvalidInputs()
		{
			ProcessInvalidInput(string.Empty);
			ProcessInvalidInput("kqKQX");
			ProcessInvalidInput("kqKQK");
			ProcessInvalidInput("qk");
		}

		[TestMethod]
		public void TestValidInputs()
		{
			ProcessValidInputs(ParseConsts.ARG_NULL, (Castling.None, Castling.None));
			ProcessValidInputs("k", (Castling.King, Castling.None));
			ProcessValidInputs("qKQ", (Castling.Queen, Castling.King | Castling.Queen));
		}

		private static void ProcessInvalidInput(string input)
		{
			var failed = false;

			try
			{
				CastlingParser.Parse(input);
			}
			catch
			{
				failed = true;
			}

			Assert.IsTrue(failed);
		}

		private static void ProcessValidInputs(string input, (Castling Black, Castling White) expected)
		{
			Assert.AreEqual(expected, CastlingParser.Parse(input));
		}
	}
}
