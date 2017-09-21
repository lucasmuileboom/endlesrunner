using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField]private int maxSpeed;
    [SerializeField]private int jumpForce;
    private int Speed = 2;
    private Rigidbody _Rigidbody;
    public bool jump = false;
    public bool iscrouching = false;

    void Start ()
    {
        _Rigidbody = GetComponent<Rigidbody>();
    }
	void Update ()
    {
        if (Speed > maxSpeed)
        {
            Speed = maxSpeed;
        }
        else if (Speed < maxSpeed)
        {
            //Speed += ?;
        }
        _Rigidbody.velocity = new Vector3(Speed, _Rigidbody.velocity.y, 0);
    }
    public void Jump()
    {
        if (!jump && !iscrouching)
        {
            _Rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = true;
        }       
    }
    void crouch()
    {
        if (!jump && !iscrouching)
        {
            ///collider size en transform size moet kleiner worden
        }
    }
    void standUp()
    {
        if (!jump && iscrouching)
        {
            ///collider size en transform size moet groter worden
        }
    }
}
