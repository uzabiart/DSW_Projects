using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosed
{
    public class EnemyWrong : MonoBehaviour
    {
        public enum EnemyType
        {
            Aggressive,
            Defensive
            // Dodanie nowego typu wymaga zmiany tej enumeracji
        }

        public EnemyType type;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                type = EnemyType.Aggressive;
            else if (Input.GetKeyDown(KeyCode.D))
                type = EnemyType.Defensive;

            if (Input.GetKeyDown(KeyCode.Space))
                PerformAction();
        }

        public void PerformAction()
        {
            if (type == EnemyType.Aggressive)
            {
                Debug.Log("Przeciwnik atakuje agresywnie!");
            }
            else if (type == EnemyType.Defensive)
            {
                Debug.Log("Przeciwnik broni siê!");
            }
        }
    }
}