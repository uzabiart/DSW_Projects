using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugSript : MonoBehaviour
{
    public PlayerInfo player;
    public PlayerHealthBar healthBar;

    private void Start()
    {
        healthBar.Init(player.health);
    }
}

[System.Serializable]
public class PlayerInfo
{
    public PlayerHealth health;
}

[System.Serializable]
public class PlayerHealth
{
    public string playerName;
    public CurrentMax health;
    public Action onValueChanged;

    [Button]
    public void ReceiveDamage(int damageAmount)
    {
        health.Reduce(damageAmount);
        onValueChanged?.Invoke();
    }
}

[System.Serializable]
public struct CurrentMax
{
    public int current;
    public int max;

    public void AddCurrent(int value)
    {
        current += value;
        if (current > max)
            current = max;
    }

    public void Reduce(int value)
    {
        current -= value;
        if (current < 0)
            current = 0;
    }
}
