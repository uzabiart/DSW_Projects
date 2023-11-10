using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class GenericButton : MonoBehaviour
{
    public UnityEvent click;
    public string animationId;

    private void Awake()
    {
        animationId = $"{gameObject.GetInstanceID()}_Button";
    }

    public void OnClick()
    {
        DOTween.Kill(animationId, true);
        transform.DOPunchScale(transform.localScale * -0.2f, 0.2f).SetId(animationId);
        click?.Invoke();
    }
}