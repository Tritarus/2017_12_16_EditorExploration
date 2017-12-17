using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;


public class ProtoInstllationKit : MonoBehaviour { 
 
 
    [MenuItem("Toolbox/Install Project")] 
    public static void InstallBasicStructure ()
    {
        CreateGitIgnoreAtProjectRoot();
        CreateFolderStructure();

    }

    private static void CreateFolderStructure()
    {

    }

    private static void CreateGitIgnoreAtProjectRoot()
    {
        string _gitIgnore = "/[Ll]ibrary/\n" + "/[Tt]emp/\n" + "/[Oo]bj/\n" + "/[Bb]uild/\n" + "/[Bb]uilds/\n" + "/ Assets/AssetStoreTools*\n" + "/.vs/\n" + "ExportedObj/\n" + ".consulo/\n" + "*.csproj\n" + "*.unityproj\n" + "*.sln\n" + "*.suo\n" + "*.tmp\n" + "*.user\n" + "*.userprefs\n" + "*.pidb\n" + "*.booproj\n" + "*.svd\n" + "*.pdb\n" + "*.pidb.meta\n" + "sysinfo.txt\n" + "*.apk\n" + "*.unitypackage\n";
        string pathGitIgnore = Application.dataPath + "/../.gitignore";
        if (File.Exists(pathGitIgnore))
            File.Delete(pathGitIgnore);
        File.WriteAllText(pathGitIgnore, _gitIgnore);
    }
} 
