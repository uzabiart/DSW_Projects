using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MVVM
{
    public class PlayerInfoUI : MonoBehaviour
    {
        public TextMeshProUGUI playerName;
        public TextMeshProUGUI playerLevel;

        public PlayerInfo info;

        public HealthBar healthBar;

        public void Init(PlayerInfo newInfo)
        {
            info = newInfo;
            UpdateUI();

            info.OnInfoUpdated = UpdateUI;
        }

        public void UpdateUI()
        {
            playerName.text = $"{info.playerName}";
            playerLevel.text = $"Lvl. {info.level.currentLevel}";

            healthBar.Init(info.health);
        }
    }
}