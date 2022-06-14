using System.Linq;
using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
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
            ProcessInvalidInput("rnbqkbnr/pp3pp/8/8/8/8/PPPPPPPP/RNBQKBNH");
        }

        [TestMethod]
        public void TestValidInputs()
        {
            ProcessValidInputs("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
            ProcessValidInputs("r1q2r2/1pp2kpp/1b3p2/p7/Pn1p3B/1N1P2Q1/1PP2PPP/R4RK1");
            ProcessValidInputs("kkkkkkkk/kkkkkkkk/kkkkkkkk/kkkkkkkk/8/8/8/8");
            ProcessValidInputs("8/8/8/8/8/8/8/8");
        }

        private static void ProcessInvalidInput(string input)
        {
            try
            {
                FenParser.Parse(input);
                Assert.Fail();
            }
            catch
            {
            }
        }

        private static void ProcessValidInputs(string input)
        {
            Assert.AreEqual(input, string.Join(ParseConsts.ARGS_DELIMITER_SLASH, FenParser.Parse(input).Select(row => RowToString(row))));
        }

        private static string RowToString(char[] input)
        {
            var result = string.Empty;
            var emptySpaces = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == Constants.EMPTY_CHAR)
                {
                    emptySpaces++;
                    continue;
                }

                if (emptySpaces > 0)
                {
                    result += emptySpaces;
                    emptySpaces = 0;
                }

                result += input[i];
            }

            if (emptySpaces > 0)
            {
                result += emptySpaces;
            }

            return result;
        }
    }
}