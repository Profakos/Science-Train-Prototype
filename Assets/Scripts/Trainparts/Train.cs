using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TrainScriptableObjects;

namespace TrainBattle
{
	public class Train : MonoBehaviour
	{

		[SerializeField]
		// the lower the index, the righter most the car is, 0 index is the engine
		private TrainCarSet trainCars = null;

		void Awake()
		{

		}

		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
		}
	}
}
