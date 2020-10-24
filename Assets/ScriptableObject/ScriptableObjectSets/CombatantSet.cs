using System.Collections;
using System.Collections.Generic;
using TrainBattle;
using UnityEngine;

namespace TrainScriptableObjects.ScriptableSets
{
	[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ScriptableSets/CombatantSet", order = 1)]
	public class CombatantSet : ScriptableObject
	{
		public string objectName = "New combatant set";
		private List<Combatant> combatants;

		public CombatantSet()
		{
			combatants = new List<Combatant>();
		}

		public void AddCombatant(Combatant combatant)
		{
			if (combatants.Contains(combatant)) return;

			combatants.Add(combatant);
		}

		public void RemoveCombatant(Combatant combatant)
		{
			combatants.Remove(combatant);
		}
	}
}
