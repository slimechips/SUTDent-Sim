using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Utils.General;
using Utils.Editor;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Project", menuName = "School Project")]
public class Project : Card
{
    private static StatList _stats;
    public PillarEnum pillar;
    public int points;
    public StringIntSeDict requirements = new StringIntSeDict();
    public StringIntSeDict rewards = new StringIntSeDict();
    public SimpleSOButton generateButton;

    public void GenerateCard()
    {
        Debug.Log("testing 123");
    }

    public void OnEnable()
    {
        if (_stats == default(StatList))
        {
            InitialiseStatList();
        }
        
        generateButton = new SimpleSOButton("Generate Card", GenerateCard);

    }

    private void InitialiseStatList()
    {
        try
        {
            _stats = (StatList)AssetDatabase.LoadAssetAtPath("Assets/Stats/Common Stat List.asset", typeof(StatList));
        } catch (UnityException e)
        {
            Debug.Log(e);
            return;
        }

        requirements.InitialiseValues(_stats);
        rewards.InitialiseValues(_stats);
    }

    public enum PillarEnum { Freshmore, ASD, EPD, ESD, ISTD };
}

