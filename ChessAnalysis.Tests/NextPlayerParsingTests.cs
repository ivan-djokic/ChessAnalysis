using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
	[TestClass]
	public class NextPlayerParsingTests
	{
		[TestMethod]
		public void TestInvalidInputs()
		{
			ProcessInvalidInput(string.Empty);
			ProcessInvalidInput(ParseConsts.ARG_NULL);
			ProcessInvalidInput("a");
			ProcessInvalidInput("B");
			ProcessInvalidInput("bw");
		}

		[TestMethod]
		public void TestValidInputs()
		{
			ProcessValidInputs("b", NextPlayer.Black);
			ProcessValidInputs("w", NextPlayer.White);
		}

		private static void ProcessInvalidInput(string input)
		{
			var failed = false;

			try
			{
				NextPlayerParser.Parse(input);
			}
			catch
			{
				failed = true;
			}

			Assert.IsTrue(failed);
		}

		private static void ProcessValidInputs(string input, NextPlayer expected)
		{
			Assert.AreEqual(expected, NextPlayerParser.Parse(input));
		}
	}
}
