using System.Collections;
using System.Collections.Generic;
using TrainBattle;
using UnityEngine;

namespace TrainScriptableObjects.ScriptableSets
{
	[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ScriptableSets/CombatantSet", order = 1)]
	public class CombatantSet : GenericSet<Combatant>
	{
		public CombatantSet(){ objectName = "New combatant set";}

	}
}
