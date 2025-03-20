
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgHotfixViewComponentAwakeSystem : AwakeSystem<DlgHotfixViewComponent> 
	{
		public override void Awake(DlgHotfixViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgHotfixViewComponentDestroySystem : DestroySystem<DlgHotfixViewComponent> 
	{
		public override void Destroy(DlgHotfixViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
