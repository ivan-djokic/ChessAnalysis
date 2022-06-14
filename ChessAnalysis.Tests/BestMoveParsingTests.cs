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
        public void TestInvalidInputs()
        {
            ProcessInvalidInput(string.Empty, true);
            ProcessInvalidInput("e", false);
            ProcessInvalidInput("R2xg2$", true);
            ProcessInvalidInput("Bx3b", false);
            ProcessInvalidInput("qxa8+", false);
            ProcessInvalidInput("Nxi6#", false);
            ProcessInvalidInput("ab1", false);
            ProcessInvalidInput("xe3", true);
            ProcessInvalidInput("Pe3", true);
            ProcessInvalidInput("pe3", false);
            ProcessInvalidInput("BGxb3", true);
            ProcessInvalidInput("R9xb3", true);
            ProcessInvalidInput("R21xg2+", false);

            ProcessInvalidInput("O-", true);
            ProcessInvalidInput("O-O-Ok", false);
            ProcessInvalidInput("O-O-O-O", true);
        }

        [TestMethod]
        public void TestValidInputs()
        {
            ProcessValidInput(ParseConsts.ARG_NULL, false, Constants.EMPTY_CHAR, new Point(-1, -1));
            ProcessValidInput("Kc5", false, 'k', new Point(2, 3));
            ProcessValidInput("f4", true, 'P', new Point(5, 4));
            ProcessValidInput("dxe3", false, 'p', new Point(4, 5));
            ProcessValidInput("Bxb3", true, 'B', new Point(1, 5));
            ProcessValidInput("Qxa8", false, 'q', new Point(0, 0));
            ProcessValidInput("R2xg2+", true, 'R', new Point(6, 6));
            ProcessValidInput("Naxd7#", false, 'n', new Point(3, 1));
            ProcessValidInput("Kxh6", true, 'K', new Point(7, 2));

            ProcessValidInput("O-O", true, 'K', new Point(6, 7));
            ProcessValidInput("O-O", false, 'k', new Point(6, 0));
            ProcessValidInput("O-O-O", true, 'K', new Point(2, 7));
            ProcessValidInput("O-O-O", false, 'k', new Point(2, 0));
        }

        private static void ProcessInvalidInput(string input, bool isWhite)
        {
            try
            {
                BestMoveParser.Parse(input, isWhite);
                Assert.Fail();
            }
            catch
            {
            }
        }

        private static void ProcessValidInput(string input, bool isWhite, char expectedPiece, Point expectedField)
        {
            var result = BestMoveParser.Parse(input, isWhite);

            Assert.AreEqual(expectedField, result.Field);
            Assert.AreEqual(expectedPiece, result.Piece);
            Assert.AreEqual(input == ParseConsts.ARG_NULL ? string.Empty : input, result.Value);
        }
    }
}