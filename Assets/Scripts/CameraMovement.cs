using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrainView
{

	public class CameraMovement : MonoBehaviour
	{

		private readonly float speed = 20;

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

			if (Camera.current == null)
				return;

			float xAxisValue = Input.GetAxis("Horizontal");
			float yAxisValue = Input.GetAxis("Vertical");

			Vector2 cameraPosition = Camera.current.transform.position;

			var translation = speed * Time.deltaTime;

			Camera.current.transform.Translate(new Vector2(xAxisValue * translation, yAxisValue * translation));

		}
	}
}
