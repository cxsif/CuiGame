
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_rewardItemDestroySystem : DestroySystem<Scroll_Item_rewardItem> 
	{
		public override void Destroy( Scroll_Item_rewardItem self )
		{
			self.DestroyWidget();
		}
	}
}
