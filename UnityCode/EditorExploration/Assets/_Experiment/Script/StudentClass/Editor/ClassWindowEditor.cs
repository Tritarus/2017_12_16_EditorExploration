using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ClassWindowEditor : EditorWindow{


    [MenuItem("Toolbox/Student info")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(ClassWindowEditor));
    }

    void OnGUI()
    {

        GUILayout.Label("Hello Window :) ");
        ClassEditor.DisplayButtonToExterminateOrCreateRaptor(null);
    }
}

