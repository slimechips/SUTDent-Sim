using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SubjectEditor : EditorWindow
{
    private SubjectList _subjectList;

    [MenuItem("Window/Subject Editor %#e")]
    private static void Init()
    {
        EditorWindow.GetWindow(typeof(SubjectEditor));
    }

    private void OnEnable()
    {
        string objectPath = "Assets/SubjectList";
        _subjectList = AssetDatabase.LoadAssetAtPath<SubjectList>(objectPath);
    }
}
