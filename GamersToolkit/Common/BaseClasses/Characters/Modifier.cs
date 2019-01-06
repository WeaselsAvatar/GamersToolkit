using System;
using Interfaces.Characters.Skills;

namespace Common.Characters.Skills
{
	public class Modifier : IModifier
	{
		private int m_Value;
		private ValidAction m_ValidForAction;

		public Modifier (int value, ValidAction validForAction)
		{
			m_Value = value;
			m_ValidForAction = validForAction;
		}


		public bool IsValidFor(ValidAction action)
		{
			return (action & m_ValidForAction) == m_ValidForAction;
		}

		public int Value => m_Value;
	}
}

