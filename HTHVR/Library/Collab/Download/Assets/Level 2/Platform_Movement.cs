using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
//Moves object between two points
public class Platform_Movement : MonoBehaviour
{
    protected float speed = 1;

    private int direction = 1;

    void Update() {
        transform.Translate(Vector3.forward * speed * direction * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        if (other.tag == "Target"){
            if (direction == 1)
                direction = -1;
            else
                direction = 1;
        }
    }
}