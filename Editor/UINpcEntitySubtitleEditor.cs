using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DenariiGames.UINpcEntitySubtitle))]
public class UINpcEntitySubtitleEditor : Editor
{
	public override void OnInspectorGUI()
	{
		serializedObject.Update();

		EditorGUILayout.PropertyField(serializedObject.FindProperty("uiTextSubtitle"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("formatKeySubtitle"));

		serializedObject.ApplyModifiedProperties();
	}
}
