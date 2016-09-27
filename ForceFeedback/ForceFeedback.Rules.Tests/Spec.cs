using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForceFeedback.Rules.Tests
{
	public class Spec
	{
		private readonly List<Action> _tearDownActions = new List<Action>();

		[TestInitialize]
		public void Setup()
		{
			Arrange();
			Act();
		}

		protected virtual void Arrange() { }
		protected virtual void Act() { }

		protected void OnTearDownDispose(IDisposable disposable)
		{
			_tearDownActions.Add(disposable.Dispose);	
		}

		protected void OnTearDownDo(Action tearDownAction)
		{
			_tearDownActions.Add(tearDownAction);
		}

		[TestCleanup]
		protected void Cleanup()
		{
			_tearDownActions.ForEach(tearDown => tearDown());
		}
	}
}