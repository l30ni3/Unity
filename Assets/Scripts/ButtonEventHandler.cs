using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler{

private GameObject Player;
public Transform target;

void Start() {
    // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
    VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
    for (int i = 0; i < vbs.Length; ++i){
        // Register with the virtual buttons TrackableBehaviour
        vbs[i].RegisterEventHandler(this);
    }
}

public void OnButtonPressed(VirtualButtonBehaviour vb){ 
    switch (vb.VirtualButtonName){
        case "Up":
            Debug.Log("Button Up");
        break;
        case "Down":
            Debug.Log("Button Down");
        break;
        case "Left":
            Player.transform.Rotate (new Vector3(0, -(Time.deltaTime * 1000), 0));
        break;
        case "Right":
            Player.transform.Rotate (new Vector3(0, Time.deltaTime * 1000, 0));
        break;
    }
}

public void OnButtonReleased(VirtualButtonBehaviour vb) { }
}
