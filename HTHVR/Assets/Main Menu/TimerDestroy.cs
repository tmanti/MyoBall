using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour {

	// Use this for initialization
	void Update () {
        if (gameObject.name == "Sphere(Clone)")
        {
            Destroy(gameObject, 5);
        }
    }
	
}
