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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Playermovement.Jump();
        }
    }
}
