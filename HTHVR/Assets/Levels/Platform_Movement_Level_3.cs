using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
//Moves object between two points
public class Platform_Movement_Level_3 : MonoBehaviour
{
    protected float speed = 1;

    private int direction = 1;

    void Update() {
        Vector3 position = transform.position;
        transform.Translate(Vector3.forward * speed * direction * Time.deltaTime);
        if( position.x >= 417 || position.x <= 389)
        {
            if (position.x >= 417)
                direction = -1;
            else
                direction = 1;
        }
    } 
}