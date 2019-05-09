using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Project
{
    public string name { get; private set; }
    public int manaCost { get; private set; }
    public int pillar { get; private set; }
    public Dictionary<string, int> requirements { get; private set; }
    public Diciontary<string, int> rewards { get; private set; }
    public int points { get; private set; }
}
