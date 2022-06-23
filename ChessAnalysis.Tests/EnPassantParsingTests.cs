using ChessAnalysis.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
	[TestClass]
	public class EnPassantParsingTests
	{
		[TestMethod]
		public void TestInvalidInputs()
		{
			ProcessInvalidInput(string.Empty);
			ProcessInvalidInput("a");
			ProcessInvalidInput("b36");
			ProcessInvalidInput("c2");
			ProcessInvalidInput("D3");
			ProcessInvalidInput("g3");
		}

		[TestMethod]
		public void TestValidInputs()
		{
			ProcessValidInputs(ParseConsts.ARG_NULL);
			ProcessValidInputs("e3", true);
			ProcessValidInputs("f6");
		}

		private static void ProcessInvalidInput(string input, bool isWhitePlayed = false)
		{
			var failed = false;

			try
			{
				EnPassantParser.Parse(input, isWhitePlayed);
			}
			catch
			{
				failed = true;
			}

			Assert.IsTrue(failed);
		}

		private static void ProcessValidInputs(string input, bool isWhitePlayed = false)
		{
			Assert.AreEqual(input == ParseConsts.ARG_NULL ? string.Empty : input, EnPassantParser.Parse(input, isWhitePlayed));
		}
	}
}
