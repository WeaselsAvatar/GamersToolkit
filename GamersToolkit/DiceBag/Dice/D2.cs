using System;

namespace ManualRandomNumberGenerators.Dice
{
	class D2 : AbstractDie
	{
		protected override int MinValue => 1;
		protected override int MaxValue => 3;	
	}
}

