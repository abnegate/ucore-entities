using UnityEngine;

namespace UCore.Entities
{
    public abstract class EntityBase : MonoBehaviour, IEntity
    {
        // Based on NavMeshAgent move speed
        public float movementSpeed;
        public float maximumMoveSpeed = 5f;
        public float minimumMoveSpeed = 0.1f;
        public float attackingRange = 0f;
        public float minimumDamage = 0f;
        public float maximumDamage = 0f;

        public float currentHealth = 0f;
        public float maximumHealth = 100f;
        public float fov;

        #region IEntity properties
        public EntityType Type => EntityType.Player;

        public GameObject GameObject => gameObject;

        public Vector3 Position => gameObject.transform.position;

        public float AttackRange => attackingRange;
        public float MinDamage => minimumDamage;
        public float MaxDamage => maximumDamage;

        public float MaxHealth => maximumHealth;
        public float CurrentHealth
        {
            get => currentHealth;
            set => currentHealth = value;
        }
        public bool IsDead => currentHealth <= 0;

        public float MaxMoveSpeed => maximumMoveSpeed;
        public float MinMoveSpeed => minimumMoveSpeed;
        public float MoveSpeed
        {
            get => movementSpeed;
            set => movementSpeed = value;
        }

        public float FieldOfView
        {
            get => fov;
            set => fov = value;
        }
        #endregion

        private void Awake()
        {
            currentHealth = maximumHealth;
        }

        private void Update()
        {
            if (IsDead) {
                Debug.Log("Dead!");
                gameObject.SetActive(false);
                return;
            }
        }

        public abstract void AttackTarget(IEntity target);
    }
}
