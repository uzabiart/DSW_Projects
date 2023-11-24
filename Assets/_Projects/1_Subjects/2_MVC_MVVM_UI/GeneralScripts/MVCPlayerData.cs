using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    [CreateAssetMenu(menuName = "MVC/PlayerData")]
    public class MVCPlayerData : ScriptableObject
    {
        public PlayerInfo info;
        public Action OnInfoUpdated;

        [Button]
        public void UpdateInfo()
        {
            OnInfoUpdated?.Invoke();
        }
    }

    [System.Serializable]
    public class PlayerInfo
    {
        public string playerName;
        public Health health;
        public Level level;
    }

    [System.Serializable]
    public class Health
    {
        public CurrentMax value;

        [Button]
        public void ReceiveDamage(int damageAmount)
        {
            value.Reduce(damageAmount);
        }
        [Button]
        public void HealUp(int healAmountt)
        {
            value.Add(healAmountt);
        }
    }

    [System.Serializable]
    public class Level
    {
        public int currentLevel;
    }
}
