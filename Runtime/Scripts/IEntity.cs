using UnityEngine;

namespace UCore.Entities
{
    public interface IEntity
    {
        /// <summary>
        /// Gets the type of entity.
        /// </summary>
        /// <value>
        /// The entity type.
        /// </value>
        EntityType Type { get; }

        /// <summary>
        /// Gets the Unity game object.
        /// </summary>
        /// <value>
        /// The game object.
        /// </value>
        GameObject GameObject { get; }

        /// <summary>
        /// Wrapper for getting the position easily.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        Vector3 Position { get; }

        /// <summary>
        /// Gets the attack range.
        /// </summary>
        /// <value>
        /// The attack range.
        /// </value>
        float AttackRange { get; }

        /// <summary>
        /// Gets the move speed.
        /// </summary>
        /// <value>
        /// The move speed.
        /// </value>
        float MoveSpeed { get; set; }

        /// <summary>
        /// Gets the field of view.
        /// </summary>
        /// <value>
        /// The field of view.
        /// </value>
        float FieldOfView { get; set; }

        /// <summary>
        /// Gets the minimum damage.
        /// </summary>
        /// <value>
        /// The minimum damage.
        /// </value>
        float MinDamage { get; }

        /// <summary>
        /// Gets the maximum damage.
        /// </summary>
        /// <value>
        /// The maximum damage.
        /// </value>
        float MaxDamage { get; }

        /// <summary>
        /// Gets the maximum health.
        /// </summary>
        /// <value>
        /// The maximum health.
        /// </value>
        float MaxHealth { get; }

        /// <summary>
        /// Gets or sets the current health.
        /// </summary>
        /// <value>
        /// The current health.
        /// </value>
        float CurrentHealth { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is dead.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is dead; otherwise, <c>false</c>.
        /// </value>
        bool IsDead { get; }

        /// <summary>
        /// Fires at another entity, damaging the other entity a random amount between min and max damage.
        /// </summary>
        /// <param name="target">The target.</param>
        void AttackTarget(IEntity target);
    }
}