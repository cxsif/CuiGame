namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgSetting :Entity,IAwake,IUILogic
	{

		public DlgSettingViewComponent View { get => this.Parent.GetComponent<DlgSettingViewComponent>();} 

		 

	}
}
