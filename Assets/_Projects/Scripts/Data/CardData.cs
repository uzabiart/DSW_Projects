using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(menuName = "UMI/New Card")]
public class CardData : SerializedScriptableObject
{
    public CardInfo cardInfo;

    public void PlayEffects()
    {
        foreach (Effect e in cardInfo.effects)
            e.PlayEffect();
    }
    public void DebugEffects()
    {
        foreach (Effect e in cardInfo.effects)
            Debug.Log(e.PlayEffect());
    }
}


[Sirenix.OdinInspector.ShowOdinSerializedPropertiesInInspector]
public class CardInfo
{
    public List<IEffect> effects;
}

// EFFECTS
public interface IEffect
{
}

[System.Serializable]
public abstract class Effect : IEffect
{
    public ITargetting targetting;
    public abstract string PlayEffect();
}

[System.Serializable]
public class DealDamage : Effect
{
    public int damageValue;

    public override string PlayEffect()
    {
        return $"Dealing {damageValue} damage to {targetting.GetDescription()}";
    }
}
[System.Serializable]
public class HealEffect : Effect
{
    public int healAmount;

    public override string PlayEffect()
    {
        return $"Healing {healAmount} health from {targetting.GetDescription()}";
    }
}
[System.Serializable]
public class Stun : Effect
{
    public int turnsAmount;

    public override string PlayEffect()
    {
        return $"Stunning {targetting.GetDescription()} for {turnsAmount} turns";
    }
}
[System.Serializable]
public class Dash : Effect
{
    public override string PlayEffect()
    {
        return $"{targetting.GetDescription()} Dashed and gained increased speed";
    }
}

// TARGETTING
public interface ITargetting
{
    public List<CardPlayer> GetTargets();
    public string GetDescription();
}

[System.Serializable]
public class RandomEnemy : ITargetting
{
    public string GetDescription()
    {
        return $"[Random Enemy]";
    }

    public List<CardPlayer> GetTargets()
    {
        List<CardPlayer> players = new List<CardPlayer>();
        players.Add(BattleData.enemies[UnityEngine.Random.Range(0, BattleData.enemies.Count)]);
        return players;
    }
}

[System.Serializable]
public class TargetPlayer : ITargetting
{
    public string GetDescription()
    {
        return $"[Player]";
    }

    public List<CardPlayer> GetTargets()
    {
        List<CardPlayer> players = new List<CardPlayer>();
        players.Add(BattleData.player);
        return players;
    }
}

[System.Serializable]
public class AllEnemies : ITargetting
{
    public string GetDescription()
    {
        return $"[All Enemies]";
    }

    public List<CardPlayer> GetTargets()
    {
        return BattleData.enemies;
    }
}