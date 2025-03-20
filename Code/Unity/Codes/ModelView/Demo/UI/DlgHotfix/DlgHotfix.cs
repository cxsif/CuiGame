namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgHotfix :Entity,IAwake,IUILogic
	{

		public DlgHotfixViewComponent View { get => this.Parent.GetComponent<DlgHotfixViewComponent>();} 

		 

	}
}
