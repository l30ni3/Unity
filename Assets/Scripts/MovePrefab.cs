using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time) * 360);
        // transform.Rotate(0, 100 * Time.deltaTime, 0, Space.Self);
        float x = UnityEngine.Random.Range(-10f, 10f);
        float y = UnityEngine.Random.Range(1f, 5f);
        float z = UnityEngine.Random.Range(-10f, 10f);
        Vector3 angle = new Vector3(x, y, z);
        // transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Rotate(new Vector3(90.0f, 0.0f, 0.0f) * Time.deltaTime);
    }
}
