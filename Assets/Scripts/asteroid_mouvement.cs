using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid_mouvement : MonoBehaviour
{
    Rigidbody2D physics;
    public float vel;
    void Start()
    {
        physics = GetComponent<Rigidbody2D>();
        physics.velocity = transform.forward * vel;
    }


    
}
