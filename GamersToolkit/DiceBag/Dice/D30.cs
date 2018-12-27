using System;

namespace DiceBag.Dice
{
	class D30 : AbstractDie
	{
		protected override int MinValue => 1;
		protected override int MaxValue => 31;	
	}
}

