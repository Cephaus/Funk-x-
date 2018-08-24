using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOLayers : MonoBehaviour {

	public GameObject[] objects;
	public int objectNumber;
	Renderer rend;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (objectNumber < 0)
			objectNumber = 0;

		for (int i = 0; i < objects.Length; i++) {

			if (objectNumber == i) {

				objects [i].SetActive (true);
			}
			else
			{
				objects [i].SetActive (false);
			}
		}

	}
	public void ObjectChangeRight()
	{
		if (objectNumber != objects.Length - 1 ) {
			objectNumber += 1;
		}
	}
	public void ObjectChangeLeft()
	{
		objectNumber -= 1;
	}
}
