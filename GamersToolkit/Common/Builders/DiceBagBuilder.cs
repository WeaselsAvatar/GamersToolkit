using System;
using Interfaces.Dice;
using ManualRandomNumberGenerators;

namespace Common.Builders
{
	public class DiceBagBuilder
	{
		public DiceBagBuilder ()
		{
		}

		public static DiceBagBuilder Instance => new DiceBagBuilder();

		public IDiceBag Build => new DiceBag();
	}
}

