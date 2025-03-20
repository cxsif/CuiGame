using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [FriendClass(typeof(DlgHotfix))]
	public static  class DlgHotfixSystem
	{

		public static void RegisterUIEvent(this DlgHotfix self)
		{
            self.View.E_HotfixButton.AddListener(self.OnHotfixClickHandler);
        }

		public static void ShowWindow(this DlgHotfix self, Entity contextData = null)
		{
		}

        public static void OnHotfixClickHandler(this DlgHotfix self)
        {
            self.ZoneScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Login);
        }


    }
}
