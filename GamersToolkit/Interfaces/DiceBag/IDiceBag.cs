using System;

namespace Interfaces
{
	public interface IDiceBag
	{
		IEnumerable<IDice> GrabDice(int howMany);
	}
}

