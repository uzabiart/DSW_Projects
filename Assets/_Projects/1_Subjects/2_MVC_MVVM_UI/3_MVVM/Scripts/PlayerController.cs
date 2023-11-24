using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVVM
{
    public class PlayerController : MonoBehaviour
    {
        public PlayerData data;

        public PlayerInfoUI playerUI;

        private void Start()
        {
            data.info.Init();
            playerUI.Init(data.info);
        }

        [Button]
        public void ReceiveDamage()
        {
            data.info.health.ReceiveDamage(1);
        }
        [Button]
        public void HealUp()
        {
            data.info.health.HealUp(1);
        }
        [Button]
        public void LevelUp()
        {
            data.info.level.LevelUp();
        }
    }
}