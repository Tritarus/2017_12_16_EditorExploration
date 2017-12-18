using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Life))]
public class LifeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Life myTarget = (Life)target;

        DrawDefaultInspector();
        //new Rect(10, 10, 200, 100);



        GUILayout.Label("Function");
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Resurectoin"))
        {
            myTarget.Value = 1f;


        }
        if (GUILayout.Button("Kill it"))
        {
            myTarget.Value = 0f;
        }
        GUILayout.EndHorizontal();

    }
}