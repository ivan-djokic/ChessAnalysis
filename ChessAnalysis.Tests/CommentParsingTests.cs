using ChessAnalysis.Classes;
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
            ProcessValidInputs("c0 \"\" \"\" \"\" \"\"", string.Empty, string.Empty, string.Empty, string.Empty);
            ProcessValidInputs("c0 \"a\" \"b\" \"c\" \"d\"", "a", "b", "c", "d");
        }

        private static void ProcessInvalidInput(string input)
        {
            try
            {
                CommentParser.Parse(input);
                Assert.Fail();
            }
            catch
            {
            }
        }

        private static void ProcessValidInputs(string input, string expectedPlayers, string expectedTimestamp, string expectedOpening, string expectedDefense)
        {
            var result = CommentParser.Parse(input);

            Assert.AreEqual(expectedPlayers, result.Players);
            Assert.AreEqual(expectedTimestamp, result.Timestamp);
            Assert.AreEqual(expectedOpening, result.Opening);
            Assert.AreEqual(expectedDefense, result.Defense);
        }
    }
}