
namespace ET
{
    
    public class SceneChangeFinish_ShowCurrentSceneUI: AEventAsync<EventType.SceneChangeFinish>
    {
        protected override async ETTask Run(EventType.SceneChangeFinish args)
        {
            args.ZoneScene.GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_Loading);
            args.ZoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Main);
            FlyMessageHelper.Show(args.ZoneScene, "欢迎回来");
            await ETTask.CompletedTask;
        }
    }
    
}