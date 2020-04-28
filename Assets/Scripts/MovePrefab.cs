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
        float x = UnityEngine.Random.Range(-10f, 10f);
        float y = UnityEngine.Random.Range(1f, 5f);
        float z = UnityEngine.Random.Range(-10f, 10f);
        Vector3 angle = new Vector3(x, y, z);
        transform.Rotate(new Vector3(90.0f, 0.0f, 0.0f) * Time.deltaTime);
    }
}
