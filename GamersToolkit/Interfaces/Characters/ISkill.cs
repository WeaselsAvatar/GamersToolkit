using System;
using Interfaces.Dice;
using System.Collections.Generic;

namespace Interfaces.Characters.Skills
{
	public interface ISkill
	{
		string Name { get; }
		int Value { get; set; }
		IRollResult Roll (IEnumerable<IModifier> modifiers);
	}
}

