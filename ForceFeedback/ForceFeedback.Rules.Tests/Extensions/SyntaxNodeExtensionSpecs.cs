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
	public class If_IsSyntaxBlock_is_called_on_a_MethodDeclaration : Spec
	{
		private MethodDeclarationSyntax _methodDeclaration;
		private bool _result;

		protected override void Arrange()
		{
			var tree = CSharpSyntaxTree.ParseText(Code.ClassWithMethodThatHas30LinesOfCode);
			_methodDeclaration = tree.GetRoot()
				.DescendantNodes()
				.First(node => node.Kind() == SyntaxKind.MethodDeclaration) as MethodDeclarationSyntax;
		}

		protected override void Act()
		{
			_result = _methodDeclaration.IsSyntaxBlock();
		}

		[TestMethod]
		public void Should_Result_be_false()
		{
			_result.Should().BeFalse();
		}
	}

	[TestClass]
	public class If_IsSyntaxBlock_is_called_on_a_SyntaxBlock : Spec
	{
		private BlockSyntax _methodDeclaration;
		private bool _result;

		protected override void Arrange()
		{
			var tree = CSharpSyntaxTree.ParseText(Code.ClassWithMethodThatHas30LinesOfCode);
			_methodDeclaration = tree.GetRoot()
				.DescendantNodes()
				.First(node => node.Kind() == SyntaxKind.Block) as BlockSyntax;
		}

		protected override void Act()
		{
			_result = _methodDeclaration.IsSyntaxBlock();
		}

		[TestMethod]
		public void Should_Result_be_true()
		{
			_result.Should().BeTrue();
		}
	}
}