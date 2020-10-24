using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TrainBattle;

namespace TrainScriptableObjects
{

	[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Sets/TrainCarSet", order = 1)]
	public class TrainCarSet : ScriptableObject
	{
		public string objectName = "New Train car set";
		private List<TrainCar> trainCars;

		public TrainCarSet()
		{
			trainCars = new List<TrainCar>();
		}

		public void AddTrainCar(TrainCar trainCar)
		{
			if (trainCars.Contains(trainCar)) return;

			trainCars.Add(trainCar);
			trainCars.Sort((x, y) => x.CarId.CompareTo(y.CarId));
		}

		public void RemoveTrainCar(TrainCar trainCar)
		{
			trainCars.Remove(trainCar);
		}

	}
}
