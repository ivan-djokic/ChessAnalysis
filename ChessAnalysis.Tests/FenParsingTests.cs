using System;
using ChessAnalysis.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessAnalysis.Tests
{
    [TestClass]
    public class FenParsingTests
    {
        [TestMethod]
        public void TestInvalidInputs()
        {
            ProcessInvalidInput(@"rnbqkbnr\pppppppp\8\8\8\8\PPPPPPPP\RNBQKBNR");
            ProcessInvalidInput("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNRR");
            ProcessInvalidInput("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBN");
            ProcessInvalidInput("rnbqkbnr/pppppppp/8/8/8/PPPPPPPP/RNBQKBNR");
            ProcessInvalidInput("rnbqkbnr/pppppppp/8/8/8/0/PPPPPPPP/RNBQKBNR");
            ProcessInvalidInput("rnbqkbnr/pppppppp/8/8/8/9/PPPPPPPP/RNBQKBNR");
            ProcessInvalidInput("rnbqkbnr/pppppppp/8/8/8/5P5/PPPPPPPP/RNBQKBNR");
            ProcessInvalidInput("rnbqkbnr/pp3pp/8/8/8/8/PPPPPPPP/RNBQKBNH");
        }

        [TestMethod]
        public void TestValidInputs()
        {
            var blackPawnRow = new char[] { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' };

            ProcessValidInputs("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR", new char[][]
            {
                new char[] { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' },
                blackPawnRow,
                new char[8],
                new char[8],
                new char[8],
                new char[8],
                new char[] { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                new char[] { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' }
            });

            ProcessValidInputs("r1q2r2/1pp2kpp/1b3p2/p7/Pn1p3B/1N1P2Q1/1PP2PPP/R4RK1", new char[][]
            {
                new char[] { 'r', '\0', 'q', '\0', '\0', 'r', '\0', '\0' },
                new char[] { '\0', 'p', 'p', '\0', '\0', 'k', 'p', 'p' },
                new char[] { '\0', 'b', '\0', '\0', '\0', 'p', '\0', '\0' },
                new char[] { 'p', '\0', '\0', '\0', '\0', '\0', '\0', '\0' },
                new char[] { 'P', 'n', '\0', 'p', '\0', '\0', '\0', 'B' },
                new char[] { '\0', 'N', '\0', 'P', '\0', '\0', 'Q', '\0' },
                new char[] { '\0', 'P', 'P', '\0', '\0', 'P', 'P', 'P' },
                new char[] { 'R', '\0', '\0', '\0', '\0', 'R', 'K', '\0' }
            });

            ProcessValidInputs("pppppppp/pppppppp/pppppppp/pppppppp/8/8/8/8", new char[][]
            {
                blackPawnRow,
                blackPawnRow,
                blackPawnRow,
                blackPawnRow,
                new char[8],
                new char[8],
                new char[8],
                new char[8]
            });

            ProcessValidInputs("8/8/8/8/8/8/8/8", new char[][]
            {
                new char[8],
                new char[8],
                new char[8],
                new char[8],
                new char[8],
                new char[8],
                new char[8],
                new char[8]
            });
        }

        private static bool AreEqual(char[][] expected, char[][] actual)
        {
            var rows = Math.Max(expected.Length, actual.Length);

            for (var i = 0; i < rows; i++)
            {
                var columns = Math.Max(expected[i].Length, actual[i].Length);

                for (var j = 0; j < columns; j++)
                {
                    if (expected[i][j] != actual[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static void ProcessInvalidInput(string input)
        {
            var failed = false;

            try
            {
                FenParser.Parse(input);
            }
            catch
            {
                failed = true;
            }

            Assert.IsTrue(failed);
        }

        private static void ProcessValidInputs(string input, char[][] expected)
        {
            Assert.IsTrue(AreEqual(expected, FenParser.Parse(input)));
        }
    }
}