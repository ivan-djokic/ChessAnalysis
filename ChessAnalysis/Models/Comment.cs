﻿// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

namespace ChessAnalysis.Models
{
	public class Comment
	{
		public Comment()
		{
		}

		public Comment(string players, string result, string opening, string defense)
		{
			Defense = defense;
			Opening = opening;
			Players = players;
			Result = result;
		}

		public string Defense { get; }

		public string Opening { get; }

		public string Players { get; }

		public string Result { get; }
	}
}
