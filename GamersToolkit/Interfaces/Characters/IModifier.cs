using System;

namespace Interfaces.Characters.Skills
{
	public interface IModifier
	{
		bool IsValid { get; }
		int Value { get; }
	}
}

