using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRGDirection : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D.velocity = new Vector2(Random.Range(-4f,1f), Random.Range(-4f, 1f) )* 0.30f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
