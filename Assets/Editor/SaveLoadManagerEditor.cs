using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SaveLoadManager))]
public class SaveLoadManagerEditor : Editor {
    public override void OnInspectorGUI() {
        DrawDefaultInspector();
        SaveLoadManager targetScript = (SaveLoadManager)target;

        if (GUILayout.Button("Save Game")) {
            targetScript.Save();
        }

        if (GUILayout.Button("Load Game")) {
            targetScript.Load();
        }            
        
    }
}
