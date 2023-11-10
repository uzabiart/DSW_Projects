using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosed
{
    public interface IEnemyBehavior
    {
        void PerformAction();
    }

    public class AggressiveBehavior : IEnemyBehavior
    {
        public void PerformAction()
        {
            Debug.Log("Przeciwnik atakuje agresywnie!");
        }
    }

    public class DefensiveBehavior : IEnemyBehavior
    {
        public void PerformAction()
        {
            Debug.Log("Przeciwnik broni siê!");
        }
    }
}