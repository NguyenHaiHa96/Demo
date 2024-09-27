using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using DG.Tweening;

public class DOTweenDemo : MonoBehaviour
{
    public Transform tfOwner;
    public Transform tfTarget;
    public Ease ease;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = tfOwner.position;
    }

    [Button]
    private void ResetStartPosition()
    {
        tfOwner.position = _startPosition;
    }
    
    [Button]
    private void MoveExample()
    {
        tfOwner.DOMove(tfTarget.position, 2f).SetEase(ease);
    }

    [Button]
    private void RotateExample()
    {
        tfOwner.DORotate(new Vector3(0, 90, 0), 3f).SetEase(ease);
    }

    [Button]
    private void SequenceExample()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(tfOwner.DOMove(tfTarget.position, 1f));
        sequence.Append(tfOwner.DORotate(new Vector3(0, 180, 0), 1f));
        sequence.Append(tfOwner.DOScale(new Vector3(3, 3, 3), 1f));
    }
}
