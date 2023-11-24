using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MVC
{
    public class PlayerInfoUI : MonoBehaviour
    {
        public TextMeshProUGUI playerName;
        public TextMeshProUGUI playerLevel;

        public HealthBar healthBar;

        public void UpdateUI(PlayerInfo info)
        {
            playerName.text = $"{info.playerName}";
            playerLevel.text = $"Lvl. {info.level.currentLevel}";

            healthBar.UpdateValue(info.health.value);
        }
    }
}