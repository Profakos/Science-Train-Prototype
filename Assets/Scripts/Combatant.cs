using System.Collections;
using System.Collections.Generic;
using TrainScriptableObjects.ScriptableSets;
using UnityEngine;

namespace TrainBattle
{

	public class Combatant : MonoBehaviour
	{
		public Alignment alignment;
		public int trainCarId;
		public int insideCarIndex;

		[SerializeField]
		private CombatantSet allCombatants = null;
		[SerializeField]
		private CombatantSet teamMembers = null;

		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

		}

		private void RegisterCombatant()
		{
			if (teamMembers == null) return;

			allCombatants.AddItem(this);
			teamMembers.AddItem(this);
		}

		private void UnregisterCombatant()
		{
			if (teamMembers == null) return;

			allCombatants.RemoveItem(this);
			teamMembers.RemoveItem(this);
		}
	}
}
