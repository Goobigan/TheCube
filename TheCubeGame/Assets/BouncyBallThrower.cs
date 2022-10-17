using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBallThrower : MonoBehaviour
{
    public GameObject prefab;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray r = camera.ScreenPointToRay(Input.mousePosition);

            Vector3 dir = r.GetPoint(1) - r.GetPoint(0);

            GameObject BouncyBall = Instantiate(prefab, r.GetPoint(2), Quaternion.LookRotation(dir));

            BouncyBall.GetComponent<Rigidbody>().velocity = BouncyBall.transform.forward * 20;
            Destroy(BouncyBall, 3);
        }
    }
}
