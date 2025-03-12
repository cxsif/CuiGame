using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.RewardUI)]
    public class RewardUITimer : ATimer<DlgReward>
    {
        public override void Run(DlgReward t)
        {
            t?.RefreshTimer();
        }
    }

    [FriendClass(typeof(DlgReward))]
	public static  class DlgRewardSystem
	{

		public static void RegisterUIEvent(this DlgReward self)
		{
            self.RegisterCloseEvent<DlgReward>(self.View.E_CloseButton);
            self.RegisterCloseEvent<DlgReward>(self.View.E_QuitButton);
            self.View.E_CardItemsLoopVerticalScrollRect.AddItemRefreshListener(self.OnLoopItemRefreshHandler);
        }


        public static void ShowWindow(this DlgReward self, Entity contextData = null)
		{
            self.timer = 6;
            self.RefreshTimer();
            self.RefreshReward();
        }

        public static void RefreshReward(this DlgReward self) 
        {
            int showCount = 5;
            self.AddUIScrollItems(ref self.ScrollItemRewardItems, showCount);
            self.View.E_CardItemsLoopVerticalScrollRect.SetVisible(true, showCount);
        }

        public static void OnLoopItemRefreshHandler(this DlgReward self, Transform transform, int index)
        {
            Scroll_Item_rewardItem scrollItemBagItem = self.ScrollItemRewardItems[index].BindTrans(transform);
            scrollItemBagItem.Refresh(0);
        }

        public static void HideWindow(this DlgReward self)
        {
            TimerComponent.Instance.Remove(ref self.rewardTimer);
        }

        public static void RefreshTimer(this DlgReward self)
        {
            self.timer = self.timer - 1;
            TimerComponent.Instance.Remove(ref self.rewardTimer);
            self.View.E_TimerText.text = $"{self.timer}s后自动退出";
            if (self.timer > 0)
            {
               self.rewardTimer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + 1000, TimerType.RewardUI, self);
            }
            else
            {
                self.DomainScene().GetComponent<UIComponent>().CloseWindow(self.GetParent<UIBaseWindow>().WindowID);
            }
          
        }




    }
}
