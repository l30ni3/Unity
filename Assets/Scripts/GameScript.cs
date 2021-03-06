﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public Transform myPrefab;
    public int numberOfObjects = 10;
    public float radius = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Arrange prefabs randomly on the plane
        for (int i = 0; i < numberOfObjects; i++)
        {
            float x = UnityEngine.Random.Range(-10f, 10f);
            float y = 1;
            float z = UnityEngine.Random.Range(-10f, 10f);
            Vector3 pos = new Vector3(x, y, z);
            float angleX = UnityEngine.Random.Range(-360f, 360f);
            float angleY = UnityEngine.Random.Range(-360f, 360f);
            float angleZ = UnityEngine.Random.Range(-360f, 360f);
            Quaternion rot = Quaternion.Euler(angleX, angleY, angleZ);
            // Quaternion rot = Quaternion.identity;
            Instantiate(myPrefab, pos, rot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //give prefabs behaviour
        // transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time) * 360);
        transform.Rotate(0, 100 * Time.deltaTime, 0, Space.Self);
    }
}
