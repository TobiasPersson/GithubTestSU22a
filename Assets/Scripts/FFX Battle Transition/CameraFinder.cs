using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main != null)
        {
            transform.parent = Camera.main.transform;
            transform.localRotation = Quaternion.identity;
            transform.localPosition = Vector3.zero;
        }
    }
}
