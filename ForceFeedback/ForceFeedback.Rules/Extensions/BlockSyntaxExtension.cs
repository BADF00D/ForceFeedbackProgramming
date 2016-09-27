using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ForceFeedback.Rules.Extensions {
	internal static class BlockSyntaxExtension {
		public static int CalculateLinesOfCode(this BlockSyntax block) {
			return block.WithoutLeadingTrivia()
				.WithoutTrailingTrivia()
				.GetText()
				.Lines
				.Count;
		} 
	}
}