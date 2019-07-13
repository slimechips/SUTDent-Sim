using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.Editor;

[CreateAssetMenu(fileName = "New Stat List", menuName = "Stat List")]
public class StatList : GenericList<Stat> {

    public static implicit operator List<string>(StatList list)
    {
        List<string> _stringList = new List<string>();
        foreach (Stat stat in list)
        {
            _stringList.Add(stat.name);
        }
        return _stringList;
    }
}    