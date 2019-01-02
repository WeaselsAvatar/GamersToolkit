using System;
using System.Linq;
using Common.Characters.Skills;
using Interfaces.Dice;
using System.Collections.Generic;
using Interfaces.Characters.Skills;
using ManualRandomNumberGenerators.Dice;

namespace LamentationsOfTheFlamePrincess.Character
{
	internal class Skill : AbstractSkill
	{
		internal Skill (string name, int value, IDiceBag diceBag)
			:base(name, value)
		{
		}

		public override IRollResult Roll (IEnumerable<IModifier> modifiers)
		{
			int numberOfDice = Value < 6 ? 1 : 2;

			IEnumerable<int> rollResult = DiceBag.GrabDice(DiceType.d6, numberOfDice).Select (t => t.Roll);		

			bool rollSuccess = Value < 6 ? 
				Value + modifiers.Where(t => t.IsValid).Sum(t => t.Value) - rollResult.First() >= 0 : 
				rollResult.All(t => t < 6);		

			return new RollResult (
				rollResult, 
				rollSuccess, 
				$"Rolled {Name} with result(s) {rollResult}: {rollSuccess ? "SUCCEEDED" : "FAILED"}");
		}
	}
}

