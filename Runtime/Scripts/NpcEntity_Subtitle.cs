/**
 * NpcEntity_Subtitle
 * Author: Denarii Games
 * Version: 1.0
 *
 * Adds Subtitle settings to NPC Entity.
 */

using UnityEngine;
using UnityEngine.Serialization;
using LiteNetLibManager;
using NightBlade.UnityEditorUtils;

namespace NightBlade
{
	public partial class NpcEntity
	{
		[Category(0, "Title Settings")]
		[Tooltip("This subtitle will be used while `syncSubtitle` is empty.")]
		[SerializeField]
		protected string entitySubtitle;

		[Tooltip("Subtitles by language keys")]
		[SerializeField]
		protected LanguageData[] entitySubtitles;

		[Category(100, "Sync Fields", false)]
		[SerializeField]
		protected SyncFieldString syncSubtitle = new SyncFieldString();
		public SyncFieldString SyncSubtitle
		{
			get { return syncSubtitle; }
		}

		public string Subtitle
		{
			get { return !string.IsNullOrEmpty(syncSubtitle.Value) ? syncSubtitle.Value : EntitySubtitle; }
			set { syncSubtitle.Value = value; }
		}

		public string EntitySubtitle
		{
			get { return Language.GetText(entitySubtitles, entitySubtitle); }
		}
	}
}