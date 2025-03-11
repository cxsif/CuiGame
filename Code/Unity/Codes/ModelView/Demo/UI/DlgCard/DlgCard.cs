namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgCard :Entity,IAwake,IUILogic
	{

		public DlgCardViewComponent View { get => this.Parent.GetComponent<DlgCardViewComponent>();} 

		 

	}
}
