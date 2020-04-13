using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public bool MoveForward;
    public GameObject myTargetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveForward) 
        {
            transform.position = new Vector3(Mathf.Sin(Time.time) * 10, 0, 0);
        }
        else 
        {
            transform.position = new Vector3(Mathf.Cos(Time.time) * 10, 0, 0);
        }
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time) * 360 * UnityEngine.Random.Range(-1.0f, 1.0f));
        myTargetObject.transform.position = transform.position;
    }

    void OnCollisionEnter(Collision other)
    {
        MoveForward = !MoveForward;
    }
}
