using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForceFeedback.Rules.Tests.Extensions
{
	[TestClass]
	public class IfIsNewLineMarkerIsCalledWithReturnCharacter : Spec
	{
		private bool _result;

		protected override void Act()
		{
			_result = Rules.Extensions.StringExtensions.IsNewLineMarker("\r");
		}

		[TestMethod]
		public void ResultShouldBeTrue()
		{
			_result.Should().BeTrue();
		}
	}

	[TestClass]
	public class IfIsNewLineMarkerIsCalledWithEnvironmentNewLine : Spec {
		private bool _result;

		protected override void Act() {
			_result = Rules.Extensions.StringExtensions.IsNewLineMarker(Environment.NewLine);
		}

		[TestMethod]
		public void ResultShouldBeTrue() {
			_result.Should().BeTrue();
		}
	}

	[TestClass]
	public class IfIsNewLineMarkerIsCalledWithNewLineCharacter : Spec {
		private bool _result;

		protected override void Act() {
			_result = Rules.Extensions.StringExtensions.IsNewLineMarker("\n");
		}

		[TestMethod]
		public void ResultShouldBeTrue() {
			_result.Should().BeTrue();
		}
	}
}