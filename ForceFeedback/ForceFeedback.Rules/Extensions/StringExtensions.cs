using System.Collections.Generic;

namespace ForceFeedback.Rules.Extensions
{
    internal static class StringExtensions
    {
        private static readonly HashSet<string> NewLineMarker = new HashSet<string>
        {
            "\r\n", "\r", "\n"
        }; 

		/// <summary>
		/// Determines whether given string is a NewLine marker. E.g.: RETURN, NEWLINE, ...
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
        public static bool IsNewLineMarker(this string value)
        {
            return value != null && NewLineMarker.Contains(value);
        }
    }
}