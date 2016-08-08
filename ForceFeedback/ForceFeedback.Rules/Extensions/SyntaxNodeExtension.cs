using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace ForceFeedback.Rules.Extensions
{
    internal static class SyntaxNodeExtension
    {
		/// <summary>
		/// Determines whether node is of kind SyntaxKind.Block.
		/// </summary>
		public static bool IsSyntaxBlock(this SyntaxNode node)
        {
            return node.Kind() == SyntaxKind.Block;
        }

		/// <summary>
		/// Determines whether node is of kind SyntaxKind.MethodDeclaration.
		/// </summary>
		public static bool IsMethod(this SyntaxNode node)
        {
            return node.Kind() == SyntaxKind.MethodDeclaration;
        }

		/// <summary>
		/// Determines whether node is of kind SyntaxKind.ConstructorDeclaration.
		/// </summary>
		public static bool IsConstructor(this SyntaxNode node)
        {
            return node.Kind() == SyntaxKind.ConstructorDeclaration;
        }

		/// <summary>
		/// Determines whether node is of kind SyntaxKind.SetAccessorDeclaration.
		/// </summary>
		public static bool IsSetter(this SyntaxNode node)
        {
            return node.Kind() == SyntaxKind.SetAccessorDeclaration;
        }

		/// <summary>
		/// Determines whether node is of kind SyntaxKind.GetAccessorDeclaration.
		/// </summary>
		public static bool IsGetter(this SyntaxNode node)
        {
            return node.Kind() == SyntaxKind.GetAccessorDeclaration;
        }
    }
}