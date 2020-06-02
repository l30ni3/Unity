using Unity.Entities;
using Unity.Mathematics;


[GenerateAuthoringComponent]
public struct CollectedComponent : IComponentData
{
    public bool isCollected;
    public float rotationAngle;
}

