using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TrainBattle;

namespace TrainScriptableObjects.ScriptableSets
{

	[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ScriptableSets/TrainCarSet", order = 2)]
	public class TrainCarSet : GenericSet<TrainCar>
	{
		public TrainCarSet() { objectName = "New train car set"; }
	}
}
