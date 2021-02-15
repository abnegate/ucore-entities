using System.Collections.Generic;
using UnityEngine;

namespace UCore.Entities
{
    public class EntityManager
    {
        public static readonly EntityManager instance = new EntityManager();

        private readonly Dictionary<GameObject, IEntity> _entities;

        public EntityManager()
        {
            _entities = new Dictionary<GameObject, IEntity>();
        }

        public void Register(GameObject go, IEntity entity)
        {
            _entities.Add(go, entity);
        }

        public IEntity GetEntity(GameObject go)
        {
            _entities.TryGetValue(go, out var entity);
            return entity;
        }

        public void Unregister(GameObject go)
        {
            _entities.Remove(go);
        }
    }
}
