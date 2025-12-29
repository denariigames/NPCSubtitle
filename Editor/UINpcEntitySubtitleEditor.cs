using UnityEngine;
using UnityEditor;

namespace NightBlade
{
	[CustomEditor(typeof(UINpcEntitySubtitle))]
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
}