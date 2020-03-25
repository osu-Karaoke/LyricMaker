﻿namespace LyricMaker.Checker
{
    /// <summary>
    /// Parameter of <see cref="TimeTagPointAutoCheck"/>
    /// </summary>
    public class TimeTagPointAutoCheckParameter
    {
        public bool CheckLineEnd { get; set; }

        public bool CheckLineEndKeyUp { get; set; }

        public bool CheckBlankLine { get; set; }

        public bool CheckWhiteSpace { get; set; }

        public bool CheckWhiteSpaceKeyUp { get; set; }

        public bool CheckWhiteSpaceAlphabet { get; set; }

        public bool CheckWhiteSpaceDigit { get; set; }

        public bool CheckWhiteSpaceAsciiSymbol { get; set; }

        public bool Checkん { get; set; }

        public bool Checkっ { get; set; }
    }
}
