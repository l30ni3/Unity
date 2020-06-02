using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;


public class CollectableSystem : SystemBase
{   

    protected override void OnUpdate()
    {
        float elapsedTime = (float)Time.ElapsedTime;
        Entities.ForEach((ref Rotation rotation, ref CollectedComponent collectable) => {
            collectable.rotationAngle += 0.003f;
            quaternion newRotation = math.mul(rotation.Value, quaternion.RotateZ(collectable.rotationAngle + elapsedTime));
            rotation.Value = newRotation;
        }).Schedule();
    }
    
}
