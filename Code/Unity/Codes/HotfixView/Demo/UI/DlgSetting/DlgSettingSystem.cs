using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace ET
{
	[FriendClass(typeof(DlgSetting))]
	public static  class DlgSettingSystem
	{

		public static void RegisterUIEvent(this DlgSetting self)
		{
            self.RegisterCloseEvent<DlgSetting>(self.View.E_CloseButton);
            self.View.E_TopButtonToggleGroup.AddListener(self.OnTopToggleSelectedHandler);
           // self.View.E_SliderSlider.onValueChanged.AddListener((float value) => { Log.Info("=====" + value); });
        }


        public static void OnTopToggleSelectedHandler(this DlgSetting self, int index)
        {
            Log.Info("==index is ===" + index);
        }

        public static void ShowWindow(this DlgSetting self, Entity contextData = null)
		{
            self.View.E_ChineseToggle.IsSelected(true);
        }

        public static void OnSliderValueChanged(float value)
        {
            Log.Info("=====" + value);
        }






    }
}
