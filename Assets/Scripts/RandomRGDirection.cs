using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRGDirection : MonoBehaviour
{
    public float vitesse = 0.007f;
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * vitesse;
    }
}
