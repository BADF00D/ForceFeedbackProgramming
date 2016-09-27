using System;

namespace ForceFeedback.Rules.Tests.CodeSnippets
{
	public static class Code
	{
		public static readonly string ClassWithMethodThatHas30LinesOfCode =
			"using System.Collections.Generic;" + Environment.NewLine 
			+ "namespace TestingForceFeedbackProgramming {" + Environment.NewLine 
			+"		public class ClassWithMethodThatHas30LinesOfCode {" + Environment.NewLine 
			+"			public static IEnumerable<byte> ReallyLongMethod() {" + Environment.NewLine 
			+ "				yield return 1;" + Environment.NewLine
			+ "				yield return 2;" + Environment.NewLine
			+ "				yield return 3;" + Environment.NewLine
			+ "				yield return 4;" + Environment.NewLine
			+ "				yield return 5;" + Environment.NewLine
			+ "				yield return 6;" + Environment.NewLine
			+ "				yield return 7;" + Environment.NewLine
			+ "				yield return 8;" + Environment.NewLine
			+"				yield return 9;" + Environment.NewLine
			+ "				yield return 10;" + Environment.NewLine
			+ "				yield return 11;" + Environment.NewLine
			+ "				yield return 12;" + Environment.NewLine
			+ "				yield return 13;" + Environment.NewLine
			+ "				yield return 14;" + Environment.NewLine
			+ "				yield return 15;" + Environment.NewLine
			+ "				yield return 16;" + Environment.NewLine
			+ "				yield return 17;" + Environment.NewLine
			+ "				yield return 18;" + Environment.NewLine
			+ "				yield return 19;" + Environment.NewLine
			+ "				yield return 20;" + Environment.NewLine
			+ "				yield return 21;" + Environment.NewLine
			+ "				yield return 22;" + Environment.NewLine
			+ "				yield return 23;" + Environment.NewLine
			+ "				yield return 24;" + Environment.NewLine
			+ "				yield return 25;" + Environment.NewLine
			+ "				yield return 26;" + Environment.NewLine
			+ "				yield return 27;" + Environment.NewLine
			+ "				yield return 28;" + Environment.NewLine
			+ "				yield return 20;" + Environment.NewLine
			+ "				yield return 30;" + Environment.NewLine
			+ "			}"					  + Environment.NewLine
			+ "		}" + Environment.NewLine
			+ "	}";

		public static readonly string MethodThatHas30LinesOfCode =
			"			public static IEnumerable<byte> ReallyLongMethod() {" + Environment.NewLine
			+ "				yield return 1;"+ Environment.NewLine
			+ "				yield return 2;"+ Environment.NewLine
			+ "				yield return 3;"+ Environment.NewLine
			+ "				yield return 4;"+ Environment.NewLine
			+ "				yield return 5;"+ Environment.NewLine
			+ "				yield return 6;"+ Environment.NewLine
			+ "				yield return 7;"+ Environment.NewLine
			+ "				yield return 8;"+ Environment.NewLine
			+ "				yield return 9;" + Environment.NewLine
			+ "				yield return 10;" + Environment.NewLine
			+ "				yield return 11;" + Environment.NewLine
			+ "				yield return 12;" + Environment.NewLine
			+ "				yield return 13;" + Environment.NewLine
			+ "				yield return 14;" + Environment.NewLine
			+ "				yield return 15;" + Environment.NewLine
			+ "				yield return 16;" + Environment.NewLine
			+ "				yield return 17;" + Environment.NewLine
			+ "				yield return 18;" + Environment.NewLine
			+ "				yield return 19;" + Environment.NewLine
			+ "				yield return 20;" + Environment.NewLine
			+ "				yield return 21;" + Environment.NewLine
			+ "				yield return 22;" + Environment.NewLine
			+ "				yield return 23;" + Environment.NewLine
			+ "				yield return 24;" + Environment.NewLine
			+ "				yield return 25;" + Environment.NewLine
			+ "				yield return 26;" + Environment.NewLine
			+ "				yield return 27;" + Environment.NewLine
			+ "				yield return 28;" + Environment.NewLine
			+ "				yield return 20;" + Environment.NewLine
			+ "				yield return 30;" + Environment.NewLine
			+ "			}";
	}
}