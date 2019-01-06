using System;
using ManualRandomNumberGenerators.InternalInterfaces;

namespace ManualRandomNumberGenerators
{
	public class SingletonRandomizer : ISingletonRandomizer
	{
		private static readonly Lazy<SingletonRandomizer> m_Instance = new Lazy<SingletonRandomizer>(() => new SingletonRandomizer ());
		private Random m_Randomizer;

		public SingletonRandomizer ()
		{
			m_Randomizer = new Random ();
		}

		public int Next(int lowerBound, int upperBound)
		{
			return m_Randomizer.Next (lowerBound, upperBound + 1);
		}

		internal static ISingletonRandomizer Instance => m_Instance.Value;
	}
}

