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
            Defensive,
            Stationary,
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
            else if (type == EnemyType.Stationary)
            {
                StationaryImplementation();
                Debug.Log("Enemy is stationary");
            }
        }

        public void StationaryImplementation()
        {
            //po czasie zmien inny state
        }
    }
}