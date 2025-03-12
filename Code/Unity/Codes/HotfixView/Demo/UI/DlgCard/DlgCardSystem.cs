using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgCard))]
    [FriendClass(typeof(Scroll_Item_cardItem))]
    public static  class DlgCardSystem
	{

		public static void RegisterUIEvent(this DlgCard self)
		{
            self.RegisterCloseEvent<DlgCard>(self.View.E_CloseButton);
            self.View.E_TopButtonToggleGroup.AddListener(self.OnTopToggleSelectedHandler);
            self.View.E_PreviousButton.AddListener(self.OnPreviousPageHandler);
            self.View.E_NextButton.AddListener(self.OnNextPageHandler);
            self.View.E_CardItemsLoopVerticalScrollRect.AddItemRefreshListener(self.OnLoopItemRefreshHandler);
        }

        public static void OnTopToggleSelectedHandler(this DlgCard self, int index)
        {
            self.CurrentTabType = (CardTabType)index;
            self.CurrentPageIndex = 0;
            self.Refresh();
        }

        public static void OnLoopItemRefreshHandler(this DlgCard self, Transform transform, int index)
        {
            Scroll_Item_cardItem scrollItemBagItem = self.ScrollItemCardItems[index].BindTrans(transform);

            index = (self.CurrentPageIndex * 30) + index;
            scrollItemBagItem.Refresh(0);
        }


        public static void ShowWindow(this DlgCard self, Entity contextData = null)
		{
            self.View.E_SoliderToggle.IsSelected(true);
        }

        public static void HideWindow(this DlgCard self)
        {
            self.RemoveUIScrollItems(ref self.ScrollItemCardItems);
        }

        public static void OnPreviousPageHandler(this DlgCard self)
        {
            --self.CurrentPageIndex;
            self.Refresh();
        }

        public static void OnNextPageHandler(this DlgCard self)
        {
            ++self.CurrentPageIndex;
            self.Refresh();
        }

        public static void Refresh(this DlgCard self)
        {
            self.RefreshItems();
            self.RefeshPageIndexInfo();
        }

        public static void RefreshItems(this DlgCard self)
        {
            int showCount = 40;
            showCount = showCount > 30 ? 30 : showCount;
            self.AddUIScrollItems(ref self.ScrollItemCardItems, showCount);
            self.View.E_CardItemsLoopVerticalScrollRect.SetVisible(true, showCount);
        }


        public static void RefeshPageIndexInfo(this DlgCard self)
        {
            int itemCount = 40;
            int maxShowCount = (self.CurrentPageIndex * 30) + 30;

            self.View.E_PreviousButton.interactable = self.CurrentPageIndex != 0;
            self.View.E_NextButton.interactable = itemCount > maxShowCount;

            int maxPageIndex = Mathf.CeilToInt(itemCount / 30.0f);
            self.View.E_PageText.text = $"{self.CurrentPageIndex + 1} / {maxPageIndex}";
        }

    }
}
