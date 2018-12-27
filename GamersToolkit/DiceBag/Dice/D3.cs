using System;

namespace DiceBag.Dice
{
	class D3 : AbstractDie
	{
		protected override int MinValue => 1;
		protected override int MaxValue => 4;	
	}
}

