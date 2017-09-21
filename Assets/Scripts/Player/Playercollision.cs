using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
    Playermovement Playermovement;

    void Start()
    {
        Playermovement = GetComponent<Playermovement>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            //gameover
        }
        if (collision.gameObject.tag == "floor")
        {
            Playermovement.jump = false;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            Playermovement.jump = true;
        }
    }
}
