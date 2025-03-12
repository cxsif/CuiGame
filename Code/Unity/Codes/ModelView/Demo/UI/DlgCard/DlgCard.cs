using System.Collections.Generic;

namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgCard :Entity,IAwake,IUILogic
	{

		public DlgCardViewComponent View { get => this.Parent.GetComponent<DlgCardViewComponent>();}

        public Dictionary<int, Scroll_Item_cardItem> ScrollItemCardItems;

        public CardTabType CurrentTabType;

        public int CurrentPageIndex = 0;

    }
}
