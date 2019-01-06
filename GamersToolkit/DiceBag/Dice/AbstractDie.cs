using System;
using Interfaces.Dice;
using ManualRandomNumberGenerators.InternalInterfaces;

namespace ManualRandomNumberGenerators.Dice
{
	abstract class AbstractDie : IDice
	{
		private ISingletonRandomizer m_Randomizer;

		protected abstract int MinValue { get;}
		protected abstract int MaxValue { get;}

		private ISingletonRandomizer Randomizer => m_Randomizer ?? (m_Randomizer = SingletonRandomizer.Instance);

		public int Roll => Randomizer.Next(MinValue, MaxValue);
	}
}

