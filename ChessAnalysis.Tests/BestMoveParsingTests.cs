using System.Drawing;
using ChessAnalysis.Classes;
using ChessAnalysis.Models;
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
            ProcessInvalidInput("Sb1", false);
            ProcessInvalidInput("xe3", true);
            ProcessInvalidInput("Pe3", true);
            ProcessInvalidInput("pe3", false);
            ProcessInvalidInput("BGxb3", true);
            ProcessInvalidInput("R9xb3", true);
            ProcessInvalidInput("R21xg2+", false);

            ProcessInvalidInput("e1=", true);
            ProcessInvalidInput("=Q", true);
            ProcessInvalidInput("b1=J", false);
            ProcessInvalidInput("i1=R", true);
            ProcessInvalidInput("c2=R", false);
            ProcessInvalidInput("a1=Q", true);
            ProcessInvalidInput("a1=P", false);
            ProcessInvalidInput("h8=K", true);

            ProcessInvalidInput("O-", true);
            ProcessInvalidInput("O-O-Ok", false);
            ProcessInvalidInput("O-O-O-O", true);
        }

        [TestMethod]
        public void TestValidInputs()
        {
            ProcessValidInput(ParseConsts.ARG_NULL, false, new BestMove(string.Empty, Constants.EMPTY_CHAR, new Point(-1, -1)));
            ProcessValidInput("Kc5", false, new BestMove("Kc5", 'k', new Point(2, 3)));
            ProcessValidInput("f4", true, new BestMove("f4", 'P', new Point(5, 4)));
            ProcessValidInput("dxe3", false, new BestMove("dxe3", 'p', new Point(4, 5)));
            ProcessValidInput("Bxb3", true, new BestMove("Bxb3", 'B', new Point(1, 5)));
            ProcessValidInput("Qxa8", false, new BestMove("Qxa8", 'q', new Point(0, 0)));
            ProcessValidInput("Rhxc8", false, new BestMove("Rhxc8", 'r', new Point(2, 0)));
            ProcessValidInput("R2xg2+", true, new BestMove("R2xg2+", 'R', new Point(6, 6)));
            ProcessValidInput("Naxd7#", false, new BestMove("Naxd7#", 'n', new Point(3, 1)));
            ProcessValidInput("Kxh6", true, new BestMove("Kxh6", 'K', new Point(7, 2)));

            ProcessValidInput("h8=R", true, new BestMove("h8=R", 'R', new Point(7, 0)));
            ProcessValidInput("a1=Q", false, new BestMove("a1=Q", 'q', new Point(0, 7)));

            ProcessValidInput("O-O", true, new BestMove("O-O", 'K', new Point(6, 7)));
            ProcessValidInput("O-O", false, new BestMove("O-O", 'k', new Point(6, 0)));
            ProcessValidInput("O-O-O", true, new BestMove("O-O-O", 'K', new Point(2, 7)));
            ProcessValidInput("O-O-O", false, new BestMove("O-O-O", 'k', new Point(2, 0)));
        }

        private static void ProcessInvalidInput(string input, bool isWhite)
        {
            var failed = false;

            try
            {
                BestMoveParser.Parse(input, isWhite);
            }
            catch
            {
                failed = true;
            }

            Assert.IsTrue(failed);
        }

        private static void ProcessValidInput(string input, bool isWhite, BestMove expected)
        {
            var result = BestMoveParser.Parse(input, isWhite);

            Assert.AreEqual(expected.Field, result.Field);
            Assert.AreEqual(expected.Piece, result.Piece);
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}