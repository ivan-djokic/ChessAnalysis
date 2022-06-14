using ChessAnalysis.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
    [TestClass]
    public class IdParsingTests
    {
        [TestMethod]
        public void TestInvalidInputs()
        {
            ProcessInvalidInput(string.Empty);
            ProcessInvalidInput(ParseConsts.ARG_NULL);
            ProcessInvalidInput("0");
            ProcessInvalidInput("i \"1\"");
            ProcessInvalidInput("ID \"2\"");
            ProcessInvalidInput("id\"3\"");
            ProcessInvalidInput("id '4'");
            ProcessInvalidInput("id 5");
        }

        [TestMethod]
        public void TestValidInputs()
        {
            ProcessValidInputs("id \"6\"", "6");
        }

        private static void ProcessInvalidInput(string input)
        {
            try
            {
                IdParser.Parse(input);
                Assert.Fail();
            }
            catch
            {
            }
        }

        private static void ProcessValidInputs(string input, string expectedId)
        {
            Assert.AreEqual(expectedId, IdParser.Parse(input));
        }
    }
}