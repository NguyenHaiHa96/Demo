using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public enum ELevelType
{
    None = 0,
    Time = 1,
    Normal = 2
}

[CreateAssetMenu(fileName = "LevelConfig", menuName = "Scriptable Objects/Level Config")]
public class LevelConfig : ScriptableObject
{
    public int id;
    [PreviewField(80, ObjectFieldAlignment.Center)] public Sprite sprIcon;
    public ELevelType type;
    [ShowIf(nameof(IsLevelTime))] public float time;

#if UNITY_EDITOR

    private bool IsLevelTime() => type == ELevelType.Time;

#endif
    
}
