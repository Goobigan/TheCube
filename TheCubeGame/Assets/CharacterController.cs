using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    Rigidbody rigidbody;
    bool allowJump = true;   
    public  CameraControl CameraTransform;

    private void OnCollisionEnter(Collision collision)
    {
        //if statement to stop infinite jumping
        if (collision.gameObject.CompareTag("Ground"))
        {
            allowJump = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {

        //Base movement controls
        rigidbody = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward *10* Time.deltaTime;
        
        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward *10* Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right *10* Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position +=  transform.right *10* Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && allowJump)
        {
            rigidbody.AddForce(Vector3.up * 250);
            allowJump = false;
        }

        //An attempt to get the character to face the same direction as the camera
        //transform.rotation = Quaternion.Euler(0, CameraTransform.eulerAngles.y, 0);




    }
}
