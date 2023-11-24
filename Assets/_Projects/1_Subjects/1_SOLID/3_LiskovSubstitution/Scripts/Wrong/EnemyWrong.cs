using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Liskov
{
    public abstract class EnemyWrong
    {
        public abstract void Attack();
        public abstract void Move();
        public abstract void TakeDamage(int damage);
    }

    public class GoblinWrong : EnemyWrong
    {
        public override void Attack()
        {
            Debug.Log("Attack with a club");
        }

        public override void Move()
        {
            Debug.Log("Moves");
        }

        public override void TakeDamage(int damage)
        {
            Debug.Log("Takes damage");
        }
    }

    public class TurretWrong : EnemyWrong
    {
        public override void Attack()
        {
            Debug.Log("Attack with the cannon");
        }

        public override void Move()
        {
        }

        public override void TakeDamage(int damage)
        {
            Debug.Log("Takes no damage");
        }
    }
}