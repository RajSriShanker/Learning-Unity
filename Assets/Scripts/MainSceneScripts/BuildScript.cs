using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildScript
{
    [MenuItem("Custom/Build WebGL")]
    public static void BuildWebGL()
    {
        string[] scenes = { "Assets/Scenes/MainScene.unity" }; // Add your scene paths here

        // Specify the build target and output directory
        BuildPipeline.BuildPlayer(scenes, "Builds/WebGL", BuildTarget.WebGL, BuildOptions.None);
    }
}