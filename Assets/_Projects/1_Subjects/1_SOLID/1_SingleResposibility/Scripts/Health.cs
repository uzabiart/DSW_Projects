using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingleResponsibility
{
    public class Health : MonoBehaviour
    {
        public int maxHealth = 100;
        private int currentHealth;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                TakeDamage(10);
            }
        }

        void Start()
        {
            currentHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            Debug.Log($"{gameObject.name} took {damage} damage. Current health: {currentHealth}");

            if (currentHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log($"{gameObject.name} has died.");
        }

        public void Heal(int healingAmount)
        {
            currentHealth += healingAmount;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
            Debug.Log($"{gameObject.name} healed by {healingAmount}. Current health: {currentHealth}");
        }
    }
}
