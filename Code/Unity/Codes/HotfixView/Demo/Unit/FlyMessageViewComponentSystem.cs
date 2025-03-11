using DG.Tweening;
using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class FlyMessageComponentAwakeSystem : AwakeSystem<FlyMessageViewComponent>
    {
        public override void Awake(FlyMessageViewComponent self)
        {
            self.Awake().Coroutine();
        }
    }


    public class FlyMessageComponentDestroySystem : DestroySystem<FlyMessageViewComponent>
    {
        public override void Destroy(FlyMessageViewComponent self)
        {
            ForeachHelper.Foreach<GameObject>(self.FlyingMessageSet, (o) =>
            {
                o.transform.DOKill();
                GameObject.Destroy(o);
            });
            self.FlyingMessageSet.Clear();
        }
    }


    [FriendClass(typeof(GlobalComponent))]
    [FriendClass(typeof(FlyMessageViewComponent))]
    public static class FlyMessageViewComponentSystem
    {
        public static async ETTask Awake(this FlyMessageViewComponent self)
        {
            await ResourcesComponent.Instance.LoadBundleAsync("flyMessage.unity3d");
            GameObject prefabGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("flyMessage.unity3d", "flyMessage");
            await GameObjectPoolHelper.InitPoolFormGamObjectAsync(prefabGameObject, 3);
        }


        public static async ETTask SpawnFlyMessage(this FlyMessageViewComponent self, string content,Vector3 startPos)
        {
            GameObject flyDamageValueGameObject = GameObjectPoolHelper.GetObjectFromPool("flyMessage");
            flyDamageValueGameObject.transform.SetParent(GlobalComponent.Instance.OtherRoot);
            flyDamageValueGameObject.transform.localScale = Vector3.one;
            self.FlyingMessageSet.Add(flyDamageValueGameObject);
            flyDamageValueGameObject.SetActive(true);

            flyDamageValueGameObject.GetComponentInChildren<Text>().text = content;
            flyDamageValueGameObject.transform.localPosition = startPos;

            flyDamageValueGameObject.transform.DOMoveY(startPos.y + 0.8f, 2f).onComplete = () =>
            {
                flyDamageValueGameObject.SetActive(false);
                self.FlyingMessageSet.Remove(flyDamageValueGameObject);
                GameObjectPoolHelper.ReturnObjectToPool(flyDamageValueGameObject);
            };
            await ETTask.CompletedTask;
        }

    }
}