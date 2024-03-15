using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class PlayACardDebug : MonoBehaviour
{
    public CardData exampleCard;

    [Button]
    public void PlayACard()
    {
        Debug.Log($"[{exampleCard.name}] Played");
        exampleCard.DebugEffects();
    }
}