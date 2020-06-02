using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class SpawnSystem : SystemBase
{
    BeginInitializationEntityCommandBufferSystem m_EntityCommandBufferSystem;
    
    protected override void OnCreate(){
        m_EntityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
    }
    
    protected override void OnUpdate(){
        //Random System Tutorial: https://reeseschultz.com/random-number-generation-with-unity-dots/
        var randomArray = World.GetExistingSystem<RandomSystem>().RandomArray;
        var commandBuffer = m_EntityCommandBufferSystem.CreateCommandBuffer().ToConcurrent();
        
        Entities
            .WithNativeDisableParallelForRestriction(randomArray)
            .ForEach((Entity entity, int nativeThreadIndex, int entityInQueryIndex, in SpawnCollectableComponent collectables) =>
        {
            for (int i = 1; i < collectables.numberOfObjects; i++){
                    
                var random = randomArray[nativeThreadIndex];
                float randomX = random.NextInt(-10, 10);
                float randomZ = random.NextInt(-10, 10);
                float3 pos = new float3(randomX, 1, randomZ);
                    
                Entity entityInstance = commandBuffer.Instantiate(entityInQueryIndex, collectables.CollectablePrefab);

                commandBuffer.AddComponent(entityInQueryIndex, entityInstance, new Translation { Value = pos });
                commandBuffer.AddComponent(entityInQueryIndex, entityInstance, new CollectedComponent { isCollected = false, rotationAngle=0f});

                randomArray[nativeThreadIndex] = random; 
            }

            commandBuffer.DestroyEntity(entityInQueryIndex, entity);
        }).ScheduleParallel();
        
        m_EntityCommandBufferSystem.AddJobHandleForProducer(Dependency);
    }
}
