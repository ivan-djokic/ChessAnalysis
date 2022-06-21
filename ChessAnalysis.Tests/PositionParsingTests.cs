using ChessAnalysis.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
    [TestClass]
    /// <summary>
    /// Tests HalfMoves and Round arguments in Position
    /// All other Position atributes are already tested in other classes
    /// </summary>
    public class PositionParsingTests
    {
        [TestMethod]
        public void TestInvalidInputs()
        {
            ProcessInput(string.Empty);
            ProcessInput(ParseConsts.ARG_NULL);
            ProcessInput("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 bm -");
            ProcessInput("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0  bm -");
            ProcessInput("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - a 1 bm -");
        }

        [TestMethod]
        public void TestValidInputs()
        {
            ProcessInput("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1 bm -", false);
        }

        private static void ProcessInput(string input, bool failExpected = true)
        {
            var failed = false;

            try
            {
                PositionParser.Parse(input);
            }
            catch
            {
                failed = true;
            }

            Assert.IsFalse(failExpected ^ failed);
        }
    }
}