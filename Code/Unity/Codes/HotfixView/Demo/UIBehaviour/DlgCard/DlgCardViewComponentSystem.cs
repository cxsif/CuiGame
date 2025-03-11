
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgCardViewComponentAwakeSystem : AwakeSystem<DlgCardViewComponent> 
	{
		public override void Awake(DlgCardViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgCardViewComponentDestroySystem : DestroySystem<DlgCardViewComponent> 
	{
		public override void Destroy(DlgCardViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
