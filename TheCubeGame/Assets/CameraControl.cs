using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Quaternion CameraTransform;
    
    public float Sensitivity
    {
        get
        {
            return sensitivity;
        }
        set
        {
            sensitivity = value;
        }
    }


    [Range(.1f, 9f)] [SerializeField] float sensitivity = 5f;
    [Range(0f, 110f)] [SerializeField] float yRotationLimit = 100f;

    public Vector2 rotation = Vector2.zero;
    
    const string xAxis = "Mouse X";
    const string yAxis = "Mouse Y";

    // Start is called before the first frame update
    void Start()
    {
        //makes a lot of ball thrower work redundant, but it clashed too much with rotation, had to be done
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame

    void Update()
    {
        rotation.x += Input.GetAxis(xAxis) * (sensitivity*5);
        rotation.y += Input.GetAxis(yAxis) * (sensitivity*5);
        rotation.y = Mathf.Clamp(rotation.y, -yRotationLimit, yRotationLimit);
        var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left);

        CameraTransform = transform.localRotation = xQuat * yQuat;
        

}
    internal object eulerAngles = yAxis;
}
