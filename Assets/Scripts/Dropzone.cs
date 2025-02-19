using UnityEngine;
using UnityEngine.EventSystems;
public class Dropzone : MonoBehaviour,IDropHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnDrop(PointerEventData eventData)
    {
        /*GameObject droppedCard = eventData.pointerDrag;
        if (droppedCard != null && droppedCard.GetComponent<Drag>() != null)
        {
            droppedCard.transform.SetParent(transform);
            droppedCard.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

            Debug.Log($"Carte {droppedCard.name} déposée dans {gameObject.name}");
        }*/
    }
    
}
