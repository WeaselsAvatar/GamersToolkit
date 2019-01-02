using System;
using System.Linq;
using Interfaces.Dice;
using System.Collections.Generic;
using ManualRandomNumberGenerators.Dice;

namespace ManualRandomNumberGenerators
{
	public class DiceBag : IDiceBag
	{
		private DiceFactory DiceFactory => new DiceFactory();

		public IEnumerable<IDice> GrabDice(DiceType what, int howMany)
		{
			for(int i = 0; i < howMany; i++)
			{
				yield return DiceFactory.CreateDie(what);
			}
		}

		public IDice GrabDice(DiceType what)
		{
			return GrabDice(what, 1).First();
		}	
	}
}

