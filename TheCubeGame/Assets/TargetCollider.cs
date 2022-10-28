using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollider : MonoBehaviour

{
    public int NumberOfTargets;
    public GameObject target;



    // Start is called before the first frame update
    void Start()
    {
        NumberOfTargets = 10;

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnCollisionEnter(Collision collision)
    {

        
        //no longer functions, as the targets are destroyed so resets count to 10 every time target is destroyed
        if (NumberOfTargets == 1)
        {
            print("Mission Complete!");
        }
        else
        {
            print("One Target Down! Only " + (NumberOfTargets - 1) + "Remaining");
            NumberOfTargets = NumberOfTargets - 1;
        }
        Destroy(target, 0);
    }
}
