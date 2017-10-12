using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField]private int maxSpeed;
    [SerializeField]private int jumpForce;
    private Rigidbody _Rigidbody;
    private float Speed = 2;
    public bool isjump = false;
    public bool iscrouching = false;

    private void Start ()
    {
        _Rigidbody = GetComponent<Rigidbody>();
        _Rigidbody.velocity = new Vector3(Speed, _Rigidbody.velocity.y, 0);
    }
	private void FixedUpdate ()
    {
        _Rigidbody.velocity = new Vector3(Speed, _Rigidbody.velocity.y, 0);
    }
    public void Jump()
    {
        if (!isjump && !iscrouching)
        {
            _Rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isjump = true;
        }       
    }
    public void crouch()//weer op de grond zetten
    {
        if (!isjump && !iscrouching)
        {
            iscrouching = true;
            GetComponent<CapsuleCollider>().transform.localScale = new Vector3(1,1,1);
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        }
    }
    public void standUp()
    {
        if (!isjump && iscrouching)
        {
            iscrouching = false;
            GetComponent<CapsuleCollider>().transform.localScale = new Vector3(1,2,1);
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        }
    }
    public void getMoreSpeed()
    {
        if (Speed > maxSpeed)
        {
            Speed = maxSpeed;
        }
        if (Speed < maxSpeed)
        {
            Speed += 0.05f;
        }
        print(Speed);
    }
}
