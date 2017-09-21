using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	void Update () {
        transform.Translate(10f * Time.deltaTime, 0f, 0f);
    }
}
