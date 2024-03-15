using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleData : MonoBehaviour
{
    public static List<CardPlayer> enemies = new List<CardPlayer>();
    public static CardPlayer player;
}

public class CardPlayer
{
    public Health health;
    public List<CardData> listOfCards;
}

public class Health
{
    public MaxCurrent healthValue;
    public Action onDamaged;
    public Action onKilled;
    public Action onHealed;

    public void Damage(int amount)
    {
        healthValue.Manage(amount * -1);
        onDamaged?.Invoke();
    }
    public void Heal(int amount)
    {
        healthValue.Manage(amount);
        onHealed?.Invoke();
        if (healthValue.current <= 0) onKilled?.Invoke();
    }
}

public struct MaxCurrent
{
    public float current;
    public float max;

    public void Manage(float value)
    {
        current += value;
        if (current > max) current = max;
    }
}