using System.Drawing;
using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
    [TestClass]
    public class BestMoveParsingTests
    {
        [TestMethod]
        public void TestCastlingInputs()
        {
            ProcessValidInputs("O-O", true, 'K', new Point(6, 7));
            ProcessValidInputs("O-O-O", false, 'k', new Point(2, 0));
            
            ProcessInvalidInputs("O-", true);
            ProcessInvalidInputs("O-O-Ok", false);
            ProcessInvalidInputs("O-O-O-O", true);
        }

        [TestMethod]
        public void TestInvalidInputs()
        {
            ProcessInvalidInputs(string.Empty, true);
            ProcessInvalidInputs("e", false);
            ProcessInvalidInputs("R21xg2+", false);
        }

        [TestMethod]
        public void TestInvalidRegularInputs()
        {
            ProcessInvalidInputs("R2xg2$", true);
            ProcessInvalidInputs("Bx3b", false);
            ProcessInvalidInputs("qxa8+", false);
            ProcessInvalidInputs("Nxi6#", false);
            ProcessInvalidInputs("ab1", false);
            ProcessInvalidInputs("xe3", true);
            ProcessInvalidInputs("Pe3", true);
            ProcessInvalidInputs("pe3", false);
            ProcessInvalidInputs("BGxb3", true);
            ProcessInvalidInputs("R9xb3", true);
        }

        [TestMethod]
        public void TestValidRegularInputs()
        {
            ProcessValidInputs("-", false, '\0', new Point(-1, -1));
            ProcessValidInputs("Kc5", false, 'k', new Point(2, 3));
            ProcessValidInputs("f4", true, 'P', new Point(5, 4));
            ProcessValidInputs("dxe3", false, 'p', new Point(4, 5));
            ProcessValidInputs("Bxb3", true, 'B', new Point(1, 5));
            ProcessValidInputs("Qxa8", false, 'q', new Point(0, 0));
            ProcessValidInputs("R2xg2+", true, 'R', new Point(6, 6));
            ProcessValidInputs("Naxd7#", false, 'n', new Point(3, 1));
            ProcessValidInputs("Kxh6", true, 'K', new Point(7, 2));
        }

        private void ProcessInvalidInputs(string input, bool isWhite)
        {
            try
            {
                BestMoveParser.Parse(input, isWhite);
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }

        private void ProcessValidInputs(string input, bool isWhite, char expectedPiece, Point expectedField)
        {
            var bestMove = BestMoveParser.Parse(input, isWhite);

            Assert.AreEqual(expectedField, bestMove.Field);
            Assert.AreEqual(expectedPiece, bestMove.Piece);

            if (input == ParseConsts.ARG_NULL)
            {
                Assert.IsNull(bestMove.Value);
                return;
            }

            Assert.AreEqual(input, bestMove.Value);
        }
    }
}