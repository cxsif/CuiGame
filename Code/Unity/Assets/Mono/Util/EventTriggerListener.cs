
using UnityEngine;
using UnityEngine.EventSystems;
public class EventTriggerListener : UnityEngine.EventSystems.EventTrigger
{
    public object paramter = null;
    public bool isAnim = true;

    public delegate void VoidDelegate(object go, PointerEventData eventData);
    public VoidDelegate onClick;
    public VoidDelegate onDown;
    public VoidDelegate onEnter;
    public VoidDelegate onExit;
    public VoidDelegate onUp;
    public VoidDelegate onSelect;
    public VoidDelegate onUpdateSelect;
    public VoidDelegate onBeginDrag;
    public VoidDelegate onDrag;
    public VoidDelegate onEndDrag;

    static public EventTriggerListener Get(GameObject go)
    {
        EventTriggerListener listener = go.GetComponent<EventTriggerListener>();
        if (listener == null) listener = go.AddComponent<EventTriggerListener>();
        return listener;
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (onClick != null) onClick(paramter, eventData);
    }
    public override void OnPointerDown(PointerEventData eventData)
    {

        if (onDown != null)
        {
            onDown(paramter, eventData);
        }

        if (isAnim)
        {
            gameObject.transform.localScale = Vector3.one * 0.8f;
        }
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        if (onUp != null)
        {
            onUp(paramter, eventData);
        }
        if (isAnim)
        {
            gameObject.transform.localScale = Vector3.one;
        }

    }
    public override void OnBeginDrag(PointerEventData eventData)
    {
        if (onBeginDrag != null)
        {
            onBeginDrag(paramter, eventData);
        }
    }

    public override void OnDrag(PointerEventData eventData)
    {
        if (onDrag != null)
        {
            onDrag(paramter, eventData);
        }
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        if (onEndDrag != null)
        {
            onEndDrag(paramter, eventData);
        }
    }

}
