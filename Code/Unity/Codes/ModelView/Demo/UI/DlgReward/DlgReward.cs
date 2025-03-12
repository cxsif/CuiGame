using System.Collections.Generic;

namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgReward :Entity,IAwake,IUILogic
	{
		public DlgRewardViewComponent View { get => this.Parent.GetComponent<DlgRewardViewComponent>();}

        public Dictionary<int, Scroll_Item_rewardItem> ScrollItemRewardItems;

        public long rewardTimer = 0;

		public int timer = 5;
    }
}
