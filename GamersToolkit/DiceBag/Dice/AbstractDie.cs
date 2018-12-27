using System;
using Interfaces.Dice;

namespace DiceBag.Dice
{
	abstract class AbstractDie : IDice
	{
		private Random m_Randomizer;

		protected abstract int MinValue { get;}
		protected abstract int MaxValue { get;}

		private Random Randomizer => m_Randomizer ?? (m_Randomizer = new Random());

		public int Roll => Randomizer.Next(MinValue, MaxValue);
	}
}

