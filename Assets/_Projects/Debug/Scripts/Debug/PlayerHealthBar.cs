using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerHealthBar : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public Image healthBar;
    public PlayerHealth viewModel;

    public void Init(PlayerHealth healthInfo)
    {
        viewModel = healthInfo;
        UpdateUI();
        viewModel.onValueChanged += UpdateUI;
    }
    private void OnDisable()
    {
        viewModel.onValueChanged -= UpdateUI;
    }

    public void UpdateUI()
    {
        healthText.text = $"{viewModel.health.current}/{viewModel.health.max}";
        healthBar.DOFillAmount((float)viewModel.health.current / (float)viewModel.health.max, 0.3f).SetEase(Ease.InOutBounce);
    }
}