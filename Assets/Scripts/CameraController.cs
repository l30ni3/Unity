using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
     //Public variable to store a reference to the player game object
     public Transform target;
 
     //Private variable to store the offset distance between the player and camera
     private Vector3 offsetPosition;
 
     private Space offsetPositionSpace = Space.Self;
 
     private bool lookAt = true;
 
     void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offsetPosition = transform.position - target.transform.position;
    }
    
    private void Update()
    {
        // followWithoutRotation();
        followWithRotation();
    }
 
    
    public void followWithoutRotation()
    {
        // compute position
        transform.position = target.position + offsetPosition;
 
        // compute rotation
        if(lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }

    public void followWithRotation()
    {
        if(target == null)
        {
            // Debug.LogWarning("Missing target ref !", this);
 
            return;
        }
 
        // compute position
        if(offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }
 
        // compute rotation
        if(lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }
}
