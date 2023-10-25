using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRgbdDirection : MonoBehaviour
{

    public Rigidbody2D myRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag =  "destrucible";
        myRigidbody2D.velocity = new Vector2(Random.Range(-4f,1f), Random.Range(-4f, 1f) )* 0.30f;
    }

    private void OnCollisionEnter2D(Collider col ) 
    {
        if (col.gameObject.tag == "bordure")
        {
            Collider;
        }


     }
    // Update is called once per frame
    void Update()
    {
        
    }
}
