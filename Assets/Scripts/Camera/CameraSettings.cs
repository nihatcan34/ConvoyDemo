using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public Transform convoy_transform;

    // Update is called once per frame
    void Update()
    {
       // Camera.main.transform.position = new Vector3(convoy_transform.position.x, Camera.main.transform.position.y, convoy_transform.position.z);
    }
}
