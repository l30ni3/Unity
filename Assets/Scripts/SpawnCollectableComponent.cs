using Unity.Entities;

[GenerateAuthoringComponent]
public struct SpawnCollectableComponent : IComponentData
{
    public int numberCollectables;
    public Entity CollectablePrefab;
}
