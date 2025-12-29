/**
 * UINpcEntitySubtitle
 * Author: Denarii Games
 * Version: 1.0
 *
 * Add component to CanvasNpcUI or use prefab CanvasNpcSubtitleUI.
 */

using Cysharp.Text;
using UnityEngine;
using NightBlade;

namespace DenariiGames
{
	[RequireComponent(typeof(NpcEntity))]
	public class UINpcEntitySubtitle : MonoBehaviour
	{
		[Header("NPC Entity - UI Elements")]
		public TextWrapper uiTextSubtitle;

		[Header("NPC Entity - String Formats")]
		public UILocaleKeySetting formatKeySubtitle = new UILocaleKeySetting(UIFormatKeys.UI_FORMAT_SIMPLE);
/*
		protected override void AddEvents(NpcEntity entity)
		{
			base.AddEvents(entity);

			if (entity == null)
				return;
			entity.SyncSubtitle.onChange += OnSyncSubtitleChanged;
		}

		protected override void RemoveEvents(NpcEntity entity)
		{
			base.RemoveEvents(entity);

			if (entity == null)
				return;
			entity.SyncSubtitle.onChange -= OnSyncSubtitleChanged;
		}

		protected override void UpdateData()
		{
			base.UpdateData();
			UpdateSubtitle();
		}

		private void OnSyncSubtitleChanged(bool isInitial, string oldSubTitle, string value)
		{
			UpdateSubtitle();
		}

		protected void UpdateSubtitle()
		{
			if (uiTextSubtitle == null)
				return;
			string tempTitle = Data == null ? string.Empty : Data.Subtitle;
			uiTextSubtitle.SetGameObjectActive(!string.IsNullOrEmpty(tempTitle));
			uiTextSubtitle.text = ZString.Format(
				LanguageManager.GetText(formatKeySubtitle),
				tempTitle);
		}
*/
	}
}