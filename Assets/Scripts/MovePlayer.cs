using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // float x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        // float z = Input.GetAxis("Vertical")  * Time.deltaTime * 3.0f;

        // transform.Rotate(0,x,0);
        // transform.Translate(x,0,z);
        
        // //tbd
        // Quaternion rotation = Quaternion.LookRotation(x, Vector3.up);
        // transform.rotation = rotation;

        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");
  
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.LookRotation(movement);
  
        transform.Translate (movement * 3.0f * Time.deltaTime, Space.World);
        
    }
}
