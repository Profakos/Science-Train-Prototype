using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
	
	[SerializeField]
	// the lower the index, the righter most the car is, 0 index is the engine
	private List<TrainCar> trainCars = new List<TrainCar>();

	void Awake()
	{
		trainCars.AddRange(this.gameObject.transform.GetComponentsInChildren<TrainCar>());
		trainCars.Sort((x, y) =>x.CarId.CompareTo(y.CarId));
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
