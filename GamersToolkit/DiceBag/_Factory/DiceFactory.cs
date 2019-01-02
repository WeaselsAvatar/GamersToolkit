using System;
using Interfaces.Dice;
using System.Collections.Generic;

namespace ManualRandomNumberGenerators.Dice
{
	internal class DiceFactory
	{
		private IDictionary<DiceType, Func<IDice>> KnownDice;

		internal DiceFactory ()
		{
			KnownDice = new Dictionary<DiceType, Func<IDice>> ();
			KnownDice.Add (DiceType.d2, () => new D2());
			KnownDice.Add (DiceType.d3, () => new D3());
			KnownDice.Add (DiceType.d4, () => new D4());
			KnownDice.Add (DiceType.d5, () => new D5());
			KnownDice.Add (DiceType.d6, () => new D6());
			KnownDice.Add (DiceType.d8, () => new D8());
			KnownDice.Add (DiceType.d10, () => new D10());
			KnownDice.Add (DiceType.d12, () => new D12());
			KnownDice.Add (DiceType.d14, () => new D14());
			KnownDice.Add (DiceType.d16, () => new D16());
			KnownDice.Add (DiceType.d20, () => new D20());
			KnownDice.Add (DiceType.d24, () => new D24());
			KnownDice.Add (DiceType.d30, () => new D30());
			KnownDice.Add (DiceType.d100, () => new D100());
		}

		internal IDice CreateDie(DiceType type)
		{
			if (!KnownDice.ContainsKey (type))
				throw new InvalidOperationException ($"{type} is not a recognized die type.");

			return KnownDice [type] ();			
		}
	}
}

