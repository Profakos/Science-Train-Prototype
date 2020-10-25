using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrainScriptableObjects.ScriptableSets
{
	public class GenericSet<T> : ScriptableObject
	{
		public string objectName = "New set";
		private List<T> items = new List<T>();

		public void AddItem(T item)
		{
			if (items.Contains(item)) return;

			items.Add(item);
		}

		public void RemoveItem(T item)
		{
			items.Remove(item);
		}
	}
}


