using System;

namespace DiceBag.Dice
{
	class D12 : AbstractDie
	{
		protected override int MinValue => 1;
		protected override int MaxValue => 13;	
	}
}

