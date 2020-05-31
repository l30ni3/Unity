using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class PlayerBehaviourSystem : SystemBase
{
    protected override void OnUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        
        Entities.ForEach((ref PlayerComponent player, ref Translation trans, ref Rotation rot) =>
        {
            player.rotationAngle += moveHorizontal * player.speed;
            float3 targetDirection = new float3((float)Math.Sin(player.rotationAngle), 0, (float)Math.Cos(player.rotationAngle));
            rot.Value = quaternion.LookRotationSafe(targetDirection, Vector3.up);
            trans.Value = trans.Value+( targetDirection * player.speed * moveVertical);
        }).Schedule();

    }
}
