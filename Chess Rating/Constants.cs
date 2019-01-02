﻿namespace Chess_Rating
{
    public static class Constants
    {
        /// <summary>
        /// Id for the Chess Scoreboard Spreadsheet
        /// </summary>
        public static readonly string SpreadsheetId = "1EcjGl22n3CaxF9x0BJzPaNBxi8C3C-uMqWsxtmkkFTs";

        /// <summary>
        /// Name of the app
        /// </summary>
        public static readonly string AppName = "Chess Scoreboard";

        /// <summary>
        /// Name of the DataStore to be creating on obtaining a user credential
        /// </summary>
        public static readonly string CredDataStoreLocation = "token.json";

        public static class Games
        {
            /// <summary>
            /// The last row to be read or written to
            /// </summary>
            public static readonly int LastRow = 201;

            /// <summary>
            /// The name of the 'Games' sheet in the Spreadsheet
            /// </summary>
            public static readonly string SheetName = "Games";

            /// <summary>
            /// Range containing the list of games played
            /// </summary>
            public static readonly string FullRange = $"{SheetName}!$A$2:$D${LastRow}";

            /// <summary>
            /// Range containing the list of games played, excluding the column for player rank
            /// </summary>
            public static readonly string RangeExcludingRank = $"{SheetName}!$B$2:$D${LastRow}";

            /// <summary>
            /// The column containing the winner's name
            /// </summary>
            public static readonly string WinnerColumn = "$B";

            /// <summary>
            /// The column containing the loser's name
            /// </summary>
            public static readonly string LoserColumn = "$C";

            /// <summary>
            /// The column containing whether the match was a stalemate
            /// </summary>
            public static readonly string StalemateColumn = "$D";

        }

        public static class Players
        {
            /// <summary>
            /// The last row to be read or written to
            /// </summary>
            public static readonly int LastRow = 201;

            /// <summary>
            /// The name of the 'Players' sheet in the Spreadsheet
            /// </summary>
            public static readonly string SheetName = "Players";

            /// <summary>
            /// Range containing the list of players
            /// </summary>
            public static readonly string FullRange = $"{SheetName}!$A$2:$F${LastRow}";

            /// <summary>
            /// The column containing the players' rating
            /// </summary>
            public static readonly string RatingColumn = "$F";

            /// <summary>
            /// The column containing the players' Name
            /// </summary>
            public static readonly string NameColumn = "$B";
        }
    }
}
