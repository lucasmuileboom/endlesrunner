using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDegen : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "floor" || other.gameObject.tag == "generate")
        {
            Destroy(other.gameObject);
        }
        


    }
}
