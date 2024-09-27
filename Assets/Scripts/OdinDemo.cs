using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class OdinDemo : MonoBehaviour
{
    [InlineEditor] public LevelConfig config;
    [ValueDropdown(nameof(GetOptions))] public string selectedOption;
    
    [Button]
    private void LogExample()
    {
        Debug.Log("Hello World.");
    }
    
    private List<string> GetOptions()
    {
        return new List<string> { "Option1", "Option2", "Option3" };
    }
}
 
