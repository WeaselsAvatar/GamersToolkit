using System;

namespace Interfaces.Characters.Skills
{
	[Flags]
	public enum ValidAction
	{
		MeleeAttack = 0x00,
		RangedAttack = 0x01,
		Defense = 0x02,
		Skill = 0x04,
		Temporary = 0x08
	}
}

