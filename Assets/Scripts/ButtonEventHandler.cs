using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler{

    public Transform Player;
    private bool MoveForward = false;
    private bool MoveBack = false;
    private bool TurnLeft = false;
    private bool TurnRight = false;
    float speed = 2;

    void Start() {
        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i){
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }
    }

    void Update()
    {
        if (MoveForward != false)
            Player.position += Vector3.forward * speed;
        else if (MoveBack != false)
            Player.position += -Vector3.forward * speed;
        else if (TurnLeft != false)
            Player.Rotate(-Vector3.up * speed);
        else if (TurnRight != false)
            Player.Rotate(Vector3.up * speed);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb){ 
        MoveForward = true; 
        switch (vb.VirtualButtonName){
            case "Up":
                Debug.Log("Button Up");
                MoveForward = true; 
            break;
            case "Down":
                Debug.Log("Button Down");
                MoveBack = true; 
            break;
            case "Left":
                Debug.Log("Button Left");
                TurnLeft = true; 
            break;
            case "Right":
                Debug.Log("Button Right");
                TurnRight = true; 
            break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       MoveForward = false; 
       MoveBack = false;
       TurnLeft = false;
       TurnRight = false;
    }
}
