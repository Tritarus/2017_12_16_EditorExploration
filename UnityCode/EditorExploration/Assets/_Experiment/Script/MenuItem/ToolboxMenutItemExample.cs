using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[HelpURL("https://github.com/JamsCenter/2017_10_16_UnityStarterPack/wiki/TF%23014")]
public class ToolboxMenutItemExample : MonoBehaviour {



    [MenuItem("Toolbox/ Hey mon ami")]
    public static void HeaderMenuItem()
    {
        HeyMonAmi();

    }
    [MenuItem("Assets/Toolbox/ Hey mon ami")]
    public static void ProjectMenuItem()
    {

        HeyMonAmi();

    }
    [MenuItem("Assets/Create/Toolbox/ Hey mon ami")]
    public static void ProjectCreateMenuItem()
    {

        HeyMonAmi();

    }
    [MenuItem("CONTEXT/ToolboxMenutItemExample/ Hey mon ami")]
    public static void ScriptMenuItem()
    {
        HeyMonAmi();
    }

    private static void HeyMonAmi()
    {
        Debug.Log("Hey mon ami, tu aimes ça manger des patates ?");
        GameObject g = new GameObject("Hey mon ami !");
        g.AddComponent<ToolboxMenutItemExample>();
    }

}
