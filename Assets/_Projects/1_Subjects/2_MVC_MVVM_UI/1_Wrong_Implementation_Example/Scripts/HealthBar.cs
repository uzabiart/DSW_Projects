using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVC_Wrong
{
    public class HealthBar : MonoBehaviour
    {
        public Image hpFill;
        public TextMeshProUGUI txt;

        public void UpdateValue(CurrentMax value)
        {
            txt.text = $"{value.current} / {value.max}";
            hpFill.fillAmount = (float)value.current / (float)value.max;
        }
    }
}