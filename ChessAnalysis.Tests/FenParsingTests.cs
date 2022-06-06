using System.Drawing;
using System.Reflection;
using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
    [TestClass]
    public class FenParsingTests
    {
        private Graphics? m_graphics;
        private MethodInfo? m_drawPiecesMethod;

        [TestInitialize]
        public void Initialize()
        {
            using var board = new Bitmap(1, 1);
            m_graphics = Graphics.FromImage(board);
            m_drawPiecesMethod = typeof(BoardImage).GetMethod("DrawPieces", BindingFlags.NonPublic | BindingFlags.Static);
        }

        [TestMethod]
        public void TestInvalidInputs()
        {
            ProcessInvalidInputs("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNRR");
            ProcessInvalidInputs("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBN");
            ProcessInvalidInputs("rnbqkbnr/pppppppp/8/8/8/PPPPPPPP/RNBQKBNR");
            ProcessInvalidInputs("rnbqkbnr/pppppppp/8/8/8/0/PPPPPPPP/RNBQKBNR");
            ProcessInvalidInputs("rnbqkbnr/pppppppp/0/8/8/8/PPPPPPPP/RNBQKBNH");
        }

        [TestMethod]
        public void TestValidInputs()
        {
            ProcessValidInputs("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
            ProcessValidInputs("r1q2r2/1pp2kpp/1b3p2/p7/Pn1p3B/1N1P2Q1/1PP2PPP/R4RK1");
            ProcessValidInputs("kkkkkkkk/kkkkkkkk/kkkkkkkk/kkkkkkkk/8/8/8/8");
            ProcessValidInputs("8/8/8/8/8/8/8/8");
        }

        private void ProcessInvalidInputs(string input)
        {
            try
            {
                ProcessValidInputs(input);
            }
            catch
            {
                return;
            }

            Assert.Fail();
        }

        private void ProcessValidInputs(string input)
        {
            if (m_drawPiecesMethod == null || m_graphics == null)
            {
                Assert.Fail();
                return;
            }

            m_drawPiecesMethod?.Invoke(null, new object[] { m_graphics, 300, input, null });
        }
    }
}