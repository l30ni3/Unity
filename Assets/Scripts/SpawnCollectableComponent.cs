using Unity.Entities;

[GenerateAuthoringComponent]
public struct SpawnCollectableComponent : IComponentData
{
    public int numberOfObjects;
    public Entity CollectablePrefab;
}
