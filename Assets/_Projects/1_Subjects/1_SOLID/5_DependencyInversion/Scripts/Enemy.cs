using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversion
{
    public class BattleManager
    {
        public Enemy target;
        public static Action<Enemy> OnTargetSwapped;

        public void Init()
        {
            OnTargetSwapped = UpdateTarget;
        }

        public void UpdateTarget(Enemy newTarget)
        {
            newTarget = new Troll();
            target = newTarget;
        }

        public void ResolveTurn()
        {
            target.TakeDamge();
        }
    }

    public abstract class Enemy
    {
        public IHealth healthSystem;
        public IMovement movementSystem;

        public void TakeDamge() { }
        public void Move() { }
    }

    public class Goblin : Enemy
    {
        public IHealth healthSystem = new StandardHealth();
        public IMovement movementSystem = new AgileMovement();
    }
    public class Troll : Enemy
    {
        public IHealth healthSystem = new ArmoredHealth();
        public IMovement movementSystem = new AgileMovement();
    }

    //Abstracts
    //HEALTH
    public interface IHealth
    {
        void TakeDamage();
    }
    public class StandardHealth : IHealth
    {
        public void TakeDamage()
        {
            Debug.Log("Take normal damage");
        }
    }
    public class ArmoredHealth : IHealth
    {
        public void TakeDamage()
        {
            Debug.Log("Take 2x less damage");
        }
    }

    //MOVEMENT
    public interface IMovement
    {
        void Move();
    }
    public class StandardMovement : IMovement
    {
        public void Move()
        {
        }
    }
    public class AgileMovement : IMovement
    {
        public void Move()
        {
        }
    }
}