using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Variable to store a reference to the player game object
    private Transform target;

    //Private variable to store the offset distance between the player and camera
    private Vector3 offsetPosition;
    private Space offsetPositionSpace = Space.Self;

    private bool lookAt = true;

    private void LateUpdate()
    {
        Refresh();
    }

    public void Refresh()
    {
        if (target == null)
        {
            Debug.LogWarning("Missing target ref !", this);

            return;
        }

        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }

        // compute rotation
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }
}
