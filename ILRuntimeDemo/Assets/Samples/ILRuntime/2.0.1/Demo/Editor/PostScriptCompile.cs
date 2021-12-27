using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class PostScriptCompile
{
    [UnityEditor.Callbacks.DidReloadScripts]
    private static void CopyLogicDLLToStreamingAssets()
    {
        Debug.Log("====");
        string srcFile = UnityEngine.Application.dataPath.Substring(0, UnityEngine.Application.dataPath.Length - 7) + "/Library/ScriptAssemblies/HotFix_Project.dll";
        string dstFile = Application.streamingAssetsPath + "/HotFix_Project.dll";
        File.Copy(srcFile, dstFile, true);
    }
}
