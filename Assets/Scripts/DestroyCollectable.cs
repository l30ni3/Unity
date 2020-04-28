﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollectable : MonoBehaviour
{
    // Start is called before the first frame update
    void onTriggerEnter(Collider other){
        if(other.gameObject.tag.Equals("collectable")){
            Destroy(other.gameObject);
        }
    }
}