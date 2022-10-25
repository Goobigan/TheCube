using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollider : MonoBehaviour

{
    private int NumberOfTargets;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        NumberOfTargets = 10;
    }

    // Update is called once per frame
    void Update()
    {
        private void OnCollisionEnter(Collision collision)
        {
            
            if (NumberOfTargets = 1)
            {
                print("Mission Complete!");
            }
            else
            {
                print("One Target Down! Only " + (NumberOfTargets - 1) + "Remaining");
            }
            Destroy(Target);
        }
    }
}
