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
            ProcessInvalidInput("D6");
        }

        [TestMethod]
        public void TestValidInputs()
        {
            ProcessInvalidInput(ParseConsts.ARG_NULL);
            ProcessValidInputs("e3");
            ProcessValidInputs("f6");
        }

        private static void ProcessInvalidInput(string input)
        {
            try
            {
                EnPassantParser.Parse(input);
                Assert.Fail();
            }
            catch
            {
            }
        }

        private static void ProcessValidInputs(string input)
        {
            Assert.AreEqual(input, EnPassantParser.Parse(input));
        }
    }
}