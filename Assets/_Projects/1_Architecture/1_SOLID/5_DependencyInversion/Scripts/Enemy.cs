using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversion
{
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
        public IHealth healthSystem = new StandardHealth();
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
            Debug.Log("Take reduced damage");
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