using System;

namespace Interfaces.Characters.Skills
{
	public interface IModifier
	{
		bool IsValidFor (ValidAction action);
		int Value { get; }
	}
}

