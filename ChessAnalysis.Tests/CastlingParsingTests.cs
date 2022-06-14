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
            ProcessInvalidInput("kqKQK");
            ProcessInvalidInput("kqKQX");
        }

        [TestMethod]
        public void TestValidInputs()
        {
            ProcessValidInputs(ParseConsts.ARG_NULL, Castling.None, Castling.None);
            ProcessValidInputs("k", Castling.King, Castling.None);
            ProcessValidInputs("qKQ", Castling.Queen, Castling.King | Castling.Queen);
        }

        private static void ProcessInvalidInput(string input)
        {
            try
            {
                CastlingParser.Parse(input);
                Assert.Fail();
            }
            catch
            {
            }
        }

        private static void ProcessValidInputs(string input, Castling expectedBlack, Castling expectedWhite)
        {
            var (black, white) = CastlingParser.Parse(input);

            Assert.AreEqual(expectedBlack, black);
            Assert.AreEqual(expectedWhite, white);
        }
    }
}