using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosed
{
    public class Enemy : MonoBehaviour
    {
        public IEnemyBehavior Behavior { get; set; }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                Behavior = new AggressiveBehavior();
            else if (Input.GetKeyDown(KeyCode.D))
                Behavior = new DefensiveBehavior();

            if (Input.GetKeyDown(KeyCode.Space) && Behavior != null)
                Behavior.PerformAction();
        }
    }
}