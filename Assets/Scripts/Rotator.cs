using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
}

class RotatorSystem : ComponentSystem
{
    struct Components
    {
        public Rotator Rotator;
        public Transform Transform;
    }
    protected override void OnUpdate()
    {
        foreach (var component in GetEntities<Components>())
        {
            var deltaTime = Time.deltaTime;
            
            component.Transform.Rotate(0f, component.Rotator.speed * deltaTime, 0f);
        }
    }
}
