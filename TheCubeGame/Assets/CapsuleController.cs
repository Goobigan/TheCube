using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    private float turningSpeed=60;
    private float walkSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
                

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        transform.position += Vector3.forward * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * Time.deltaTime;


        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.down,turningSpeed*Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.Rotate( Vector3.up,turningSpeed * Time.deltaTime);
        
    }
}
