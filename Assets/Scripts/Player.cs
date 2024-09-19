using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    void Start()
    {
    
    }

public Rigidbody2D RB;
public float Speed = 5;
    void Update()
    {
        Vector2 vel = new Vector2(0,0);
        if (Input.GetKey(KeyCode.RightArrow))
       {
        print("RightArrowPressed");
        vel.x = Speed;
       }
        if (Input.GetKey(KeyCode.LeftArrow))
       {
        print("LeftArrowPressed");
        vel.x = -Speed;
       }
         if (Input.GetKey(KeyCode.UpArrow))
       {
        print("UpArrowPressed");
        vel.y = Speed;
       }
        if (Input.GetKey(KeyCode.DownArrow))
       {
        print("DownArrowPressed");
        vel.y = -Speed;
       }
        RB.velocity = vel;

    }
    
}
