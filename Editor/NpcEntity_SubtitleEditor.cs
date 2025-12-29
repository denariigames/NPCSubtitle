/**
 * NpcEntity_Subtitle
 * Author: Denarii Games
 * Version: 1.0
 *
 * Adds Subtitle settings to NPC Entity.
 */

using UnityEditor;

namespace NightBlade
{
	public partial class NpcEntityEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			serializedObject.Update();

			EditorGUILayout.PropertyField(serializedObject.FindProperty("entitySubtitle"));
			EditorGUILayout.PropertyField(serializedObject.FindProperty("entitySubtitles"));

			serializedObject.ApplyModifiedProperties();
		}
	}
}