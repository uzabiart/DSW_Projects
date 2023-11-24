using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC
{
    public class PlayerController : MonoBehaviour
    {
        public MVCPlayerData data;

        public PlayerInfoUI playerUI;

        private void OnEnable()
        {
            data.OnInfoUpdated += UpdateUI;
        }
        private void OnDisable()
        {
            data.OnInfoUpdated -= UpdateUI;
        }

        private void Start()
        {
            UpdateUI();
        }

        [Button]
        public void ReceiveDamage()
        {
            data.info.health.ReceiveDamage(1);
            UpdateUI();
        }
        [Button]
        public void HealUp()
        {
            data.info.health.HealUp(1);
            UpdateUI();
        }
        [Button]
        public void LevelUp()
        {
            data.info.level.currentLevel++;
            UpdateUI();
        }

        public void UpdateUI()
        {
            playerUI.UpdateUI(data.info);
        }
    }
}