using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");
  
        Vector3 movement = new Vector3(moveSpeed * moveHorizontal* Time.deltaTime, 0.0f, moveSpeed * moveVertical * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(movement);
  
        transform.Translate (movement, Space.World);
    }
}
