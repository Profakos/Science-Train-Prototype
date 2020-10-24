using System.Collections;
using System.Collections.Generic;
using TrainScriptableObjects;
using UnityEngine;

namespace TrainBattle
{
	public class TrainCar : MonoBehaviour
	{
		[SerializeField]
		private int carId;

		[SerializeField]
		private TrainCarSet trainCars = null;

		public int CarId { get => carId; set => carId = value; }

		void OnEnable()
		{
			RegisterTrainCar();
		}

		void OnDisable()
		{
			UnregisterTrainCar();
		}

		// Start is called before the first frame update
		void Start()
		{
        
		}

		// Update is called once per frame
		void Update()
		{

		}

		private void RegisterTrainCar()
		{
			if (trainCars == null) return;

			trainCars.AddTrainCar(this);
		}

		private void UnregisterTrainCar()
		{
			if (trainCars == null) return;

			trainCars.RemoveTrainCar(this);
		}
	}
}

