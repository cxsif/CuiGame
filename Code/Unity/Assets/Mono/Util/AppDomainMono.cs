using System;
using System.Collections;
using UnityEngine;

public class AppDomainMono : MonoBehaviour
{
    public Action onAwake = () => { };
    public Action onStart = () => { };
    public Action onUpdate = () => { };
    public Action onLateUpdate = () => { };
    public Action onFixedUpdate = () => { };
    public Action onDestroy = () => { };
    public Action onEnable = () => { };
    public Action onDisable = () => { };

    // 加载脚本实例时调用 Awake
    private void Awake()
    {
        onAwake?.Invoke();
    }

    // 仅在首次调用 Update 方法之前调用 Start
    private void Start()
    {
        onStart?.Invoke();
    }

    // 如果 MonoBehaviour 已启用，则在每一帧都调用 Update
    private void Update()
    {
        onUpdate?.Invoke();
    }

    // 如果启用 Behaviour，则在每一帧都将调用 LateUpdate
    private void LateUpdate()
    {
        onLateUpdate?.Invoke();
    }

    // 如果启用 MonoBehaviour，则每个固定帧速率的帧都将调用此函数
    private void FixedUpdate()
    {
        onFixedUpdate?.Invoke();
    }

    // 当 MonoBehaviour 将被销毁时调用此函数
    private void OnDestroy()
    {
        onDestroy?.Invoke();
    }

    // 当对象已启用并处于活动状态时调用此函数
    private void OnEnable()
    {
        onEnable?.Invoke();
    }

    // 当行为被禁用或处于非活动状态时调用此函数
    private void OnDisable()
    {
        onDisable?.Invoke();
    }

    //============================================================================================================

    public Action<bool> onApplicationFocus = (bool focus) => { };
    public Action<bool> onApplicationPause = (bool pause) => { };
    public Action onApplicationQuit = () => { };

    // 当玩家获得或失去焦点时发送给所有游戏对象
    private void OnApplicationFocus(bool focus)
    {
        onApplicationFocus?.Invoke(focus);
    }

    // 当玩家暂停时发送给所有游戏对象
    private void OnApplicationPause(bool pause)
    {
        onApplicationPause?.Invoke(pause);
    }

    // 应用程序退出前发送给所有游戏对象
    private void OnApplicationQuit()
    {
        onApplicationQuit?.Invoke();
    }

    //============================================================================================================

    public Action<Collider> onTriggerEnter = (Collider collider) => { };
    public Action<Collider> onTriggerExit = (Collider collider) => { };
    public Action<Collider> onTriggerStay = (Collider collider) => { };

    // 如果另一个碰撞器进入了触发器，则调用 OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter?.Invoke(other);
    }

    // 如果另一个碰撞器停止接触触发器，则调用 OnTriggerExit
    private void OnTriggerExit(Collider other)
    {
        onTriggerExit?.Invoke(other);
    }

    // 对于触动触发器的所有“另一个碰撞器”，OnTriggerStay 将在每一帧被调用一次
    private void OnTriggerStay(Collider other)
    {
        onTriggerStay?.Invoke(other);
    }

    //============================================================================================================

    public Action onMouseDown = () => { };
    public Action onMouseDrag = () => { };
    public Action onMouseEnter = () => { };
    public Action onMouseExit = () => { };
    public Action onMouseOver = () => { };
    public Action onMouseUp = () => { };
    public Action onMouseUpAsButton = () => { };

    // 当用户在 GUIElement 或碰撞器上按鼠标按钮时调用 OnMouseDown
    private void OnMouseDown()
    {
        onMouseDown?.Invoke();
    }

    // 当用户在 GUIElement 或碰撞器上单击鼠标并保持按住鼠标时调用 OnMouseDrag
    private void OnMouseDrag()
    {
        onMouseDrag?.Invoke();
    }

    // 当鼠标进入 GUIElement 或碰撞器时调用 OnMouseEnter
    private void OnMouseEnter()
    {
        onMouseEnter?.Invoke();
    }

    // 当鼠标不再停留在 GUIElement 或碰撞器上时调用 OnMouseExit
    private void OnMouseExit()
    {
        onMouseExit?.Invoke();
    }

    // 当鼠标停留在 GUIElement 或碰撞器上时每帧都调用 OnMouseOver
    private void OnMouseOver()
    {
        onMouseOver?.Invoke();
    }

    // 当用户松开鼠标按钮时调用 OnMouseUp
    private void OnMouseUp()
    {
        onMouseUp?.Invoke();
    }

    // 仅当在同一 GUIElement 或碰撞器上按下鼠标，在松开时调用 OnMouseUpAsButton
    private void OnMouseUpAsButton()
    {
        onMouseUpAsButton?.Invoke();
    }

    //============================================================================================================

    public Action onBecameInvisible = () => { };
    public Action onBecameVisible = () => { };

    // 当呈现器在任何照相机上都不可见时调用 OnBecameInvisible
    private void OnBecameInvisible()
    {
        onBecameInvisible?.Invoke();
    }

    // 当呈现器在任何照相机上可见时调用 OnBecameVisible
    private void OnBecameVisible()
    {
        onBecameVisible?.Invoke();
    }

    //============================================================================================================

    public Coroutine DoCoroutine(IEnumerator coroutine)
    {
        return StartCoroutine(coroutine);
    }
}