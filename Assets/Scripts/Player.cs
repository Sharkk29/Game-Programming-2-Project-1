using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{

     [SerializeField]
    private Vector3 initialVelocity;
    [SerializeField]
    private float minVelocity = 10f;

    private Vector3 lastFrameVelocity;
    private Rigidbody2D rb;

    void Start()
    {
    
    }


private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = initialVelocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
    public Rigidbody2D RB;
    public float Speed = 5;
    void Update()
    {
        lastFrameVelocity = rb.velocity;
        Vector2 vel = new Vector2(0,0);
        if (Input.GetKey(KeyCode.RightArrow))
       {
        
        vel.x = Speed;
       }
        if (Input.GetKey(KeyCode.LeftArrow))
       {
        vel.x = -Speed;
       }
         if (Input.GetKey(KeyCode.UpArrow))
       {
        vel.y = Speed;
       }
        if (Input.GetKey(KeyCode.DownArrow))
       {
        vel.y = -Speed;
       }
        RB.velocity = vel;

    }
    

}

