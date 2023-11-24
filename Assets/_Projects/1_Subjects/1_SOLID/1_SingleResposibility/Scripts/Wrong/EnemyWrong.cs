using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingleResponsibility
{
    public class EnemyWrong : MonoBehaviour
    {
        // Enemy properties
        public string enemyName = "Enemy";
        public int maxHealth = 100;
        private int currentHealth;

        // Movement properties
        public float moveSpeed = 5.0f;

        // Attack properties
        public int attackDamage = 10;

        void Start()
        {
            currentHealth = maxHealth;
        }

        // Move the enemy
        private void Move(Vector3 direction)
        {
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }

        // Enemy attack
        private void Attack()
        {
            Debug.Log($"{enemyName} attacks with {attackDamage} damage.");
            // Add attack logic here
        }

        // Handle taking damage
        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            Debug.Log($"{enemyName} took {damage} damage. Current health: {currentHealth}");

            if (currentHealth <= 0)
            {
                Die();
            }
        }

        // Handle enemy death
        private void Die()
        {
            Debug.Log($"{enemyName} has died.");
            // Add death logic here
        }

        // Update is called once per frame
        void Update()
        {
            // Example movement
            if (Input.GetKey(KeyCode.UpArrow))
                Move(Vector3.up);
            if (Input.GetKey(KeyCode.DownArrow))
                Move(Vector3.down);

            // Example attack triggering
            if (Input.GetKeyDown(KeyCode.Space)) // Press Space to attack
            {
                Attack();
            }

            // Example taking damage (for demonstration purposes)
            if (Input.GetKeyDown(KeyCode.H)) // Press H to take damage
            {
                TakeDamage(10);
            }
        }
    }
}