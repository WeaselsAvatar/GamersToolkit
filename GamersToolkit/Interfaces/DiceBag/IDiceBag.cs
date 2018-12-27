using System;
using System.Collections.Generic;

namespace Interfaces.Dice
{
	public interface IDiceBag
	{
		/// <summary>
		/// Grabs some dice of a specific type.
		/// </summary>
		/// <returns>The dice.</returns>
		/// <param name="what">What kind of die you want.</param>
		/// <param name="howMany">How many you want.</param>
		IEnumerable<IDice> GrabDice(DiceType what, int howMany);

		/// <summary>
		/// Grabs a die of a specific type.
		/// </summary>
		/// <returns>The die if it exists.</returns>
		/// <param name="what">What kind of die you want.</param>
		IDice GrabDice(DiceType what);
	}
}

