using System;
using System.Collections.Generic;

namespace Task3
{
    internal class Task3
    {
        public enum ComponentType
        {
            Mortal,
            Walking,
        }

        public class Entity
        {
            public float2 pos;
            public ComponentType components;
        }

        public class GameState
        {
            public Entity[] entities;
        }
        
        //аллоцирует память в куче один раз при создании founded;
        public static int[] GetEntitiesIndicesInRadius(Entity[] entities,float2 center,float radius,ComponentType component)
        {
            int foundedArrayLength = 0;
            for (int i = 0; i < entities.Length; i++)
            {
                if (HasComponent(entities[i],component) && InRadius(entities[i].pos,center,radius))
                {
                    foundedArrayLength ++;
                }
            }

            int[] founded = new int[foundedArrayLength];
            int i2 = 0;
            for (int i = 0; i < entities.Length; i++)
            {
                if (HasComponent(entities[i],component) && InRadius(entities[i].pos,center,radius))
                {
                    founded[i2] = i;
                    i2++;
                }
            }
            return founded;
        }

        public static bool HasComponent(Entity entity,ComponentType targetComponent)
            => entity.components == targetComponent;
        public static bool InRadius(float2 pos, float2 center, float radius)
            => Math.Pow(pos.x - center.x, 2) + Math.Pow(pos.y - center.y, 2) < radius;
    }

    public struct float2
    {
        public float x;
        public float y;
    }
}