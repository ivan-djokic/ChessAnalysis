﻿using System.IO;
using System.Security.Cryptography;
using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using Timer = System.Windows.Forms.Timer;

namespace ChessAnalysis.Utils
{
    public static class Extensions
    {
        public static int AsBoardColumn(this char input, Components component)
        {
            if (!input.IsBoardColumn())
            {
                throw new UnallowedCharactersException(component);
            }

            return input - 'a';
        }

        public static int AsBoardRow(this int input)
        {
            return Constants.BOARD_SIZE - input;
        }

        public static int AsNumber(this char input, Components component)
        {
            if (!input.IsBoardRow())
            {
                throw new UnallowedCharactersException(component);
            }

            return input - '0';
        }

        public static int AsNumber(this string input, Components component)
        {
            try
            {
                return int.Parse(input);
            }
            catch
            {
                throw new UnallowedCharactersException(component);
            }
        }

        public static string AsString(this int input)
        {
            return ((char)input).ToString();
        }

        public static bool Contains(this char[][] input, BestMove value)
        {
            if (value.Field.X < 0 || value.Field.Y < 0)
            {
                return false;
            }

            return input[value.Field.Y][value.Field.X] == value.Piece;
        }

        public static bool IsBoardColumn(this char input)
        {
            return !char.IsUpper(input) && input >= 'a' && input <= 'h';
        }

        public static bool IsBoardPiece(this char input)
        {
            return Constants.PIECES.Contains(input);
        }

        public static bool IsBoardRow(this char input)
        {
            return char.IsDigit(input) && input != '0' && input != '9';
        }

        public static Color Normalize(this System.Windows.Media.Color input)
        {
            return Color.FromArgb(input.A, input.R, input.G, input.B);
        }

        public static System.Windows.Media.Color Normalize(this Color input)
        {
            return System.Windows.Media.Color.FromArgb(input.A, input.R, input.G, input.B);
        }

        public static string Read(this ICryptoTransform crypto, MemoryStream memoryStream)
        {
            using var cryptoStream = new CryptoStream(memoryStream, crypto, CryptoStreamMode.Read);
            using var reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }

        public static string RemoveLast(this string input, int count = 1)
        {
            return input.Remove(input.Length - count);
        }

        public static IEnumerable<T> RemoveNullValues<T>(this T[] input)
        {
            return input.Where(e => e != null);
        }

        public static void Restart(this Timer timer)
        {
            timer.Stop();
            timer.Start();
        }

        public static void ValidateIdUniqueness(this IEnumerable<Data> collection, string id, Data? skipIdValidation = null)
        {
            if (collection.Any(item => item?.Id == id && item != skipIdValidation))
            {
                throw new NotUniqueIdException(id);
            }
        }

        public static void Write(this ICryptoTransform crypto, MemoryStream memoryStream, string input)
        {
            using var cryptoStream = new CryptoStream(memoryStream, crypto, CryptoStreamMode.Write);
            using var writer = new StreamWriter(cryptoStream);
            writer.Write(input);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
        }
    }
}
