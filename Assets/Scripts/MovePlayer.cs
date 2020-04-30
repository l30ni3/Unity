using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed;
    public float rotAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal= Input.GetAxis("Horizontal") * Time.deltaTime;
        rotAngle += moveHorizontal;
        float moveVertical = Input.GetAxis ("Vertical");
        
  
        // moveHorizontal muss aus dem Bewegungsvektor raus
        Vector3 movement = new Vector3(0.0f, 0.0f, moveSpeed * moveVertical * Time.deltaTime);
        // In Quaternion.LookRotation() musst du einen Richtungsvektor einsetzen, keinen Bewegungsvektor
        Vector3 targetDirection = new Vector3( Mathf.Sin(rotAngle), 0, Mathf.Cos(rotAngle));
        transform.rotation = Quaternion.LookRotation(targetDirection);
  
        transform.Translate (movement);
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag.Equals("collectable")){
            Destroy(other.gameObject);
        }
    }
}
