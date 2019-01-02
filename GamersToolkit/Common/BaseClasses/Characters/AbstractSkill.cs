using System;
using Interfaces.Characters.Skills;
using Interfaces.Dice;
using Common.Builders;
using System.Collections.Generic;

namespace Common.Characters.Skills
{
	public abstract class AbstractSkill : ISkill
	{
		private string m_Name;
		private int m_Value;
		private IDiceBag m_DiceBag;

		protected AbstractSkill (string name, int value)
		{
			m_Name = name;
			m_Value = value;
		}

		protected IDiceBag DiceBag => m_DiceBag ?? (m_DiceBag = DiceBagBuilder.Instance.Build);
		public string Name => m_Name;
		public int Value
		{
			get{return m_Value;} 
			set{m_Value = value;}
		}
		public abstract IRollResult Roll (IEnumerable<IModifier> modifiers);
	}
}

