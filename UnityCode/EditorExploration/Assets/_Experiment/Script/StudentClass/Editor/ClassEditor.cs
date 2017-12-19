using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Class))]
public class ClassEditor : Editor{

    public override void OnInspectorGUI()
    {
        Debug.Log("Hey mon ami!");


        Class myTarget = (Class) base.target;

        string listOfStudents="";

        if (myTarget._myStudents != null)
        {
            for (int i = 0; i < myTarget._myStudents.Length; i++)
            {
                listOfStudents += " " + myTarget._myStudents[i]._name;
            }
            GUILayout.Label(listOfStudents);
            DisplayButtonToExterminateOrCreateRaptor(myTarget);

            if (GUILayout.Button("Create Team Folders"))
            {
                for (int i = 0; i < myTarget._myStudents.Length; i++)
                {
                    CreateFolder("_Project/Team/" + myTarget._myStudents[i]._name);
                }
            }
        }
        DrawDefaultInspector();




        //myTarget.experience = EditorGUILayout.IntField("Experience", myTarget.experience);
        //EditorGUILayout.LabelField("Level", myTarget.Level.ToString());
    }

    public static void DisplayButtonToExterminateOrCreateRaptor(Class myTarget)
    {
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Exterminate !"))
        {
            if(myTarget!=null)
             myTarget.ResetStudent();
        }
        if (GUILayout.Button("Raptor Jesus !"))
        {
            if (myTarget != null)
                myTarget._myStudents = new Student[] { new Student() { _name = "Raptor Jesus", _age = 999 } };
        }
        EditorGUILayout.EndHorizontal();
    }

    private static void CreateFolder(string path, string readMe = "...")
    {
        string appDataPath = Application.dataPath;
        path = appDataPath + "/" + path;
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);

        }
        if (Directory.GetFiles(path).Length <= 0)
            File.WriteAllText(path + "/readme.txt", readMe);

        AssetDatabase.Refresh();

    }


}
