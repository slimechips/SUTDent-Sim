using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Utils.General;

[CreateAssetMenu(fileName = "New Project", menuName = "School Project")]
public class Project : Card
{
    private static StatList _stats;
    public int pillar;
    public int points;
    public StringIntSeDict requirements = new StringIntSeDict();
    public StringIntSeDict rewards = new StringIntSeDict();

    public void OnEnable()
    {
        if (_stats == default(StatList))
        {
            InitialiseStatList();
        }
    }

    private void InitialiseStatList()
    {
        Debug.Log("initialising");
        try
        {
            _stats = (StatList)AssetDatabase.LoadAssetAtPath("Assets/Stats/Common Stat List.asset", typeof(StatList));
            Debug.Log(_stats);
        } catch (UnityException e)
        {
            Debug.Log(e);
            return;
        }

        requirements.InitialiseValues(_stats);
        rewards.InitialiseValues(_stats);
    }

}
