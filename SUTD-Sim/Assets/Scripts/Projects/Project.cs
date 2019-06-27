using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Project", menuName = "School Project")]
public class Project: Card
{
    public int pillar;
    public Dictionary<string, int> requirements;
    public Dictionary<string, int> rewards;
    public int points;
}
