using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class FlyMessageViewComponent : Entity, IAwake, IDestroy
    {
        public HashSet<GameObject> FlyingMessageSet = new HashSet<GameObject>();


    }
}