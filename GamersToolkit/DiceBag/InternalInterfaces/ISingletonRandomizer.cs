using System;

namespace ManualRandomNumberGenerators.InternalInterfaces
{
	public interface ISingletonRandomizer
	{
		int Next (int lowerBound, int upperBound);
	}
}

