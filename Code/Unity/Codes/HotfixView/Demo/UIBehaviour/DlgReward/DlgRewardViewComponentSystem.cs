
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgRewardViewComponentAwakeSystem : AwakeSystem<DlgRewardViewComponent> 
	{
		public override void Awake(DlgRewardViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgRewardViewComponentDestroySystem : DestroySystem<DlgRewardViewComponent> 
	{
		public override void Destroy(DlgRewardViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
