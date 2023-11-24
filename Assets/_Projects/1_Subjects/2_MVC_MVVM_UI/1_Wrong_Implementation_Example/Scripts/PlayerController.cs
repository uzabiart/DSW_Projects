using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MVC_Wrong
{
    public class PlayerController : MonoBehaviour
    {
        public PlayerInfo info;

        public TextMeshProUGUI playerName;
        public TextMeshProUGUI playerLevel;
        public HealthBar healthBar;

        private void Start()
        {
            UpdateUI();
        }

        [Button]
        public void ReceiveDamage()
        {
            info.health.Reduce(1);
            healthBar.UpdateValue(info.health);
        }
        [Button]
        public void HealUp()
        {
            info.health.Add(1);
            healthBar.UpdateValue(info.health);
        }
        [Button]
        public void LevelUp()
        {
            info.level++;
            playerLevel.text = $"Lvl. {info.level}";
        }

        public void UpdateUI()
        {
            playerName.text = $"{info.playerName}";
            playerLevel.text = $"Lvl. {info.level}";

            healthBar.UpdateValue(info.health);
        }
    }

    [System.Serializable]
    public class PlayerInfo
    {
        public string playerName;
        public CurrentMax health;
        public int level;
    }
}