﻿using UnityEngine;
using System.Collections;

namespace Adnc.Quest {
	[System.Serializable]
	public abstract class QuestBase {
		public string id = "";
		public string displayName = "Untitled";
		public QuestStatus status = QuestStatus.Undefined;
		public string description = "";
	}
}
