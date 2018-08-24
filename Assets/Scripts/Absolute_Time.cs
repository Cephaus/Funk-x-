using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absolute_Time : MonoBehaviour {

    [Range(0, 5)]
    public float timescale = 1.0f;
    public float TimeScale { get { return timescale;} set { timescale = value; } }


	
	// Update is called once per frame
	void Update () {
        Time.timeScale = timescale;
	}
}
