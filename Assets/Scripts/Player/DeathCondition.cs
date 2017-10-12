using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCondition : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Transform Player;

    private Vector3 MinSpeed;
    private Vector3 prevPos;
    private Vector3 currentPos;
    private IEnumerator coroutine;
    


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        coroutine = WaitAndPrint(0.05f);
        StartCoroutine(coroutine);
    }

    void Update()
    {
     if(this.transform.position.y < 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        
        prevPos = this.transform.position;
        while (true)
        {
            
            yield return new WaitForSeconds(waitTime);
            float dist = prevPos.x - this.transform.position.x;
            if (Mathf.Abs(dist) < 0.01f)
            {
                SceneManager.LoadScene(2);
                StopAllCoroutines();
            }
            prevPos = this.transform.position;
        }
        

    }


}