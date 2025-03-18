using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float xForce = 5.0f;
    public float zForce = 5.0f;
    public float yForce = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=0.0f, y=0.0f, z=0.0f;
        if(Input.GetKey(KeyCode.W))
        {
            x = x - xForce;
        }
        if(Input.GetKey(KeyCode.A))
        {
            x = x + xForce;
        }
        if(Input.GetKey(KeyCode.D))
        {
            z = z - zForce;
        }
        if(Input.GetKey(KeyCode.Q))
        {
            z = z + zForce;
        }
        if(Input.GetKey(KeyCode.S))
        {
            y = yForce;
        }
        GetComponent<Rigidbody>().AddForce(new Vector3(x, y, z));
    }
}
