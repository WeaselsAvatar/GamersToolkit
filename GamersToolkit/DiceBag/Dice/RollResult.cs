using System;
using System.Collections.Generic;
using Interfaces.Dice;

namespace ManualRandomNumberGenerators.Dice
{
	public class RollResult : Tuple<IEnumerable<int>, bool, string>, IRollResult
	{
		public RollResult (IEnumerable<int> results, bool success, string message = default(string))
			:base(results, success, message)
		{
		}

		public IEnumerable<int> Results => this.Item1;
		public bool Success => this.Item2;
		public string Message => this.Item3;
	}
}

