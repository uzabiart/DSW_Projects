using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Liskov
{
    public abstract class Enemy
    {
        public abstract void Attack();
        public abstract void TakeDamage(int damage);
    }
    public interface IMovable
    {
        void Move();
    }

    public class Goblin : Enemy, IMovable
    {
        public override void Attack()
        {
            Debug.Log("Goblin atakuje!");
        }

        public void Move()
        {
            Debug.Log("Goblin porusza siê.");
        }

        public override void TakeDamage(int damage)
        {
            Debug.Log("Goblin otrzymuje obra¿enia.");
        }
    }
    public class Turret : Enemy
    {
        public override void Attack()
        {
            Debug.Log("Turret strzela, ale nie porusza siê.");
        }

        public override void TakeDamage(int damage)
        {
            Debug.Log("Turret jest odporny na obra¿enia.");
        }
    }
}