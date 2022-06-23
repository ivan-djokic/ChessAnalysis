using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
	[TestClass]
	public class CommentParsingTests
	{
		[TestMethod]
		public void TestInvalidInputs()
		{
			ProcessInvalidInput(string.Empty);
			ProcessInvalidInput(ParseConsts.ARG_NULL);
			ProcessInvalidInput("\"a\" \"b\" \"c\" \"d\"");
			ProcessInvalidInput("c \"a\" \"b\" \"c\" \"d\"");
			ProcessInvalidInput("c0 \"a\" \"b\" \"c\" ");
			ProcessInvalidInput("c0\"a\" \"b\" \"c\" \"d\"");
			ProcessInvalidInput("c0 'a' 'b' 'c' 'd'");
			ProcessInvalidInput("c0 a b c d");
		}

		[TestMethod]
		public void TestValidInputs()
		{
			ProcessValidInputs("c0 \"\" \"\" \"\" \"\"", new Comment(string.Empty, string.Empty, string.Empty, string.Empty));
			ProcessValidInputs("c0 \"a\" \"b\" \"c\" \"d\"", new Comment("a", "b", "c", "d"));
		}

		private static void ProcessInvalidInput(string input)
		{
			var failed = false;

			try
			{
				CommentParser.Parse(input);
			}
			catch
			{
				failed = true;
			}

			Assert.IsTrue(failed);
		}

		private static void ProcessValidInputs(string input, Comment expected)
		{
			var result = CommentParser.Parse(input);

			Assert.AreEqual(expected.Players, result.Players);
			Assert.AreEqual(expected.Result, result.Result);
			Assert.AreEqual(expected.Opening, result.Opening);
			Assert.AreEqual(expected.Defense, result.Defense);
		}
	}
}