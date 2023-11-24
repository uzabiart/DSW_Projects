using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVVM
{
    [CreateAssetMenu(menuName = "MVVM/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        public PlayerInfo info;
    }

    [System.Serializable]
    public class PlayerInfo
    {
        public string playerName;
        public Health health;
        public Level level;

        public Action OnInfoUpdated;

        [Button]
        public void UpdateInfo()
        {
            OnInfoUpdated?.Invoke();
        }

        public void Init()
        {
            level.OnLevelUp = () => { OnInfoUpdated?.Invoke(); };
        }
    }

    [System.Serializable]
    public class Health
    {
        public CurrentMax value;
        public Action OnValueUpdate;

        public Action OnDamaged;
        public Action OnHealed;

        [Button]
        public void ReceiveDamage(int damageAmount)
        {
            value.Reduce(damageAmount);
            OnValueUpdate?.Invoke();
            OnDamaged?.Invoke();
        }
        [Button]
        public void HealUp(int healAmountt)
        {
            value.Add(healAmountt);
            OnValueUpdate?.Invoke();
            OnHealed?.Invoke();
        }
    }

    [System.Serializable]
    public class Level
    {
        public int currentLevel;
        public Action OnLevelUp;

        public void LevelUp()
        {
            currentLevel++;
            OnLevelUp?.Invoke();
        }
    }
}