using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public Rigidbody Point;
    void Update()
    {
        Vector3 pos = new Vector3(
        
            Random.Range(-3.35,-3.38), //This is the values for X
            Random.Range(20,-25), //This is the values for Y, the l
            0);
            Instantiate;
    }
}