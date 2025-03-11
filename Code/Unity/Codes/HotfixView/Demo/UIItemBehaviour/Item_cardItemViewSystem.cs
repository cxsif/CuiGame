
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_cardItemDestroySystem : DestroySystem<Scroll_Item_cardItem> 
	{
		public override void Destroy( Scroll_Item_cardItem self )
		{
			self.DestroyWidget();
		}
	}
}
