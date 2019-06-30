using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.General;

[CreateAssetMenu(fileName = "New Project", menuName = "School Project")]
public class Project: Card
{
    public int pillar;
    public int points;
    public StringIntSeDict requirements = new StringIntSeDict();
    public StringIntSeDict rewards = new StringIntSeDict();


}
