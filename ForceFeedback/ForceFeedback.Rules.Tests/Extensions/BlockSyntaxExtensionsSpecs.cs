using System.Linq;
using FluentAssertions;
using ForceFeedback.Rules.Extensions;
using ForceFeedback.Rules.Tests.CodeSnippets;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForceFeedback.Rules.Tests.Extensions
{
	[TestClass]
	public class IfCalculateLinesOfCodeIsCalled : Spec
	{
		private BlockSyntax _blocksyntax;
		private int _result;

		protected override void Arrange()
		{
			var tree = CSharpSyntaxTree.ParseText(Code.ClassWithMethodThatHas30LinesOfCode);
			_blocksyntax = tree.GetRoot()
				.DescendantNodes()
				.First(node => node.Kind() == SyntaxKind.Block) as BlockSyntax;
		}

		protected override void Act()
		{
			_result = _blocksyntax.CalculateLinesOfCode();
		}

		[TestMethod]
		public void LinesOfCode_should_be_30_plus_2()
		{
			//Extra two for method declaration and closing braces
			_result.Should().Be(30 + 2);
		}
	}
}