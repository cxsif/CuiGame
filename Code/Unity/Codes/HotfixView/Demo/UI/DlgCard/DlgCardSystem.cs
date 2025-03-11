using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgCard))]
	public static  class DlgCardSystem
	{

		public static void RegisterUIEvent(this DlgCard self)
		{
            self.RegisterCloseEvent<DlgCard>(self.View.E_CloseButton);
        }

		public static void ShowWindow(this DlgCard self, Entity contextData = null)
		{
		}

		 

	}
}
