using System;
using Interfaces.Characters;

namespace Interfaces.Games
{
	public interface IGameSystem
	{
		ICharacter CreateNewCharacter(string name, bool npc = false);
		ICharacter ImportExistingCharacter (string name);
		void ExportCharacter (ICharacter character);
	}
}

