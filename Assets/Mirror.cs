using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public GameObject mirrorObject; // Object to mirror
    public bool mirrorX; // Wether or not to mirror the X axis
    public bool mirrorY; // Wether or not to mirror the Y axis
    public bool mirrorZ; // Wether or not to mirror the Z axis
                         

    public bool useLateUpdate;

    Vector3 newRotation;
    void Start()
    {
        
    }

    Vector3 newPosition;

    // Update is called once per frame
    void Update()
    {
        
        newPosition = mirrorObject.transform.position; // Get the mirrorObject's position
        newRotation = mirrorObject.transform.rotation.eulerAngles;
        if (mirrorX)
        {
            newPosition.x = -newPosition.x; // Mirror on the X axis
            //newRotation.x = -newRotation.x;
        }
        if (mirrorY)
        {
            newPosition.y = -newPosition.y; // Mirror on the Y axis
        }
        if (mirrorZ)
        {
            newPosition.z = -newPosition.z; // Mirror on the Z axis
        }

        if (!useLateUpdate)
        {
            transform.position = newPosition; // Set object's position equal to the new mirrored position
            transform.rotation = Quaternion.Euler(newRotation);
        }
    }

    void LateUpdate()
    {
        if (useLateUpdate)
            transform.position = newPosition; // Set object's position equal to the new mirrored position
    }
}
