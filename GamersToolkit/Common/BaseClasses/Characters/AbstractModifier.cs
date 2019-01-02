using System;
using Interfaces.Characters.Skills;

namespace Common.Characters.Skills
{
	public abstract class AbstractModifier : IModifier
	{
		private int m_Value;

		protected AbstractModifier (int value)
		{
			m_Value = value;
		}


		public abstract bool IsValid { get; }
		public int Value => m_Value;
	}
}

