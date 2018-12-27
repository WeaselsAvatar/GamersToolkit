using System;
using System.Linq;
using Interfaces.Dice;
using System.Collections.Generic;
using DiceBag.Dice;

namespace DiceBag
{
	public class DiceBag : IDiceBag
	{
		private DiceFactory DiceFactory => new DiceFactory();

		public IEnumerable<IDice> GrabDice(DiceType what, int howMany)
		{
			IList<IDice> result = new List<IDice>();
			for(int i = 0; i < howMany; i++)
			{
				result.Add(DiceFactory.CreateDie(what));
			}
			return result;
		}

		public IDice GrabDice(DiceType what)
		{
			return GrabDice(what, 1).First();
		}
	}
}

