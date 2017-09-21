using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    Playermovement Playermovement;

    void Start ()
    {
        Playermovement = GetComponent<Playermovement>();
    }
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Playermovement.Jump();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
         
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
           
        }
    }
}
