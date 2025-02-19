using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{   
    Transform parentToReturnTo=null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (transform.parent.GetComponent<Dropzone>()==null){transform.SetParent(parentToReturnTo);}
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
