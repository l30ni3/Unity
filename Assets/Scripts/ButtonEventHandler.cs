using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler{

    public Transform Player;

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
                Player.transform.Translate(Vector3.forward * 15.0f * Time.deltaTime, Space.World);
            break;
            case "Down":
                Debug.Log("Button Down");
                Player.transform.Translate(-Vector3.forward * 15.0f * Time.deltaTime, Space.World);
            break;
            case "Left":
                Debug.Log("Button Left");
                Player.transform.position += Vector3.left * 15.0f * Time.deltaTime;
                Player.transform.Rotate (new Vector3(0, -90, 0));
            break;
            case "Right":
                Debug.Log("Button Right");
                Player.transform.position += Vector3.right * 15.0f * Time.deltaTime;
                Player.transform.Rotate (new Vector3(0, 90, 0));
            break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) { }
}
