using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgSetting))]
	public static  class DlgSettingSystem
	{

		public static void RegisterUIEvent(this DlgSetting self)
		{
            self.RegisterCloseEvent<DlgSetting>(self.View.E_CloseButton);
        }

		public static void ShowWindow(this DlgSetting self, Entity contextData = null)
		{
		}

		 

	}
}
