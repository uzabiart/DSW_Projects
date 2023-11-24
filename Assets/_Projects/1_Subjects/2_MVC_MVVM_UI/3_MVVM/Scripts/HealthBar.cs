using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVVM
{
    public class HealthBar : MonoBehaviour
    {
        public Image hpFill;
        public TextMeshProUGUI txt;
        public Health healthRef;

        public void Init(Health health)
        {
            healthRef = health;
            healthRef.OnValueUpdate = UpdateValue;
            healthRef.OnDamaged = OnDamaged;
            healthRef.OnHealed = OnHealUp;

            UpdateValue();
        }

        public void UpdateValue()
        {
            txt.text = $"{healthRef.value.current} / {healthRef.value.max}";
            hpFill.fillAmount = (float)healthRef.value.current / (float)healthRef.value.max;
        }

        public void OnDamaged()
        {
            Debug.Log("Character got damaged!!");
        }
        public void OnHealUp()
        {
            Debug.Log("Character healed up!!");
        }
    }
}