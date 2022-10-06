using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyForces : MonoBehaviour
{

    Rigidbody ourRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ourRigidBody.AddForce(Vector3.left);
        }

        if (Input.GetKey(KeyCode.S))
        {
            ourRigidBody.AddForce(Vector3.back);
        }

        if (Input.GetKey(KeyCode.W))
        {
            ourRigidBody.AddForce(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ourRigidBody.AddForce(Vector3.right);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            ourRigidBody.AddForce(Vector3.up);
        }

    }


    private void OnCollisionEnter(Collision collision)
    {

     Health ObjectHitHealth = collision.gameObject.GetComponent<Health>();

        if (ObjectHitHealth)
        {
            print("Found health script in object hit");
            ObjectHitHealth.takeDamage(20);

            int ObjectsMaxHealth = ObjectHitHealth.whatsYourMaxHealth();
            if(ObjectsMaxHealth>100)
                ObjectHitHealth.takeDamage(20);

        }
        else
        {
            print("Didn't find health script in object hit");
        }
    }
}
