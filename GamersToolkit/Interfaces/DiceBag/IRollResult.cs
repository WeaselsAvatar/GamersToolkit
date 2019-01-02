using System;
using System.Collections.Generic;

namespace Interfaces.Dice
{
	public interface IRollResult
	{
		IEnumerable<int> Results { get; }
		bool Success { get; }
		string Message { get; }
	}
}

