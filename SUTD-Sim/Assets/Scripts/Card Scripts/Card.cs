using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Project", menuName = "School Project")]
public abstract class Card : ScriptableObject
{
    public string cardName;
    public int manaCost;
    public Sprite cardArt;

}
