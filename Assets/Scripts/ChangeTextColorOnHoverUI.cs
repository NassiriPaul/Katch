using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeTextColorOnHoverUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Hover Colors")]
    public Color normalColor = Color.white; // Couleur normale du texte
    public Color hoverColor = Color.red; // Couleur lorsqu'on survole le texte

    private TextMeshProUGUI textMeshPro; // Composant TextMeshPro

    void Start()
    {
        // Récupérer le composant TextMeshPro attaché à ce GameObject
        textMeshPro = GetComponent<TextMeshProUGUI>();

        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshProUGUI component is missing on this GameObject!");
            return;
        }

        // Initialiser la couleur normale
        textMeshPro.color = normalColor;
    }

    // Quand la souris entre dans la zone du texte
    public void OnPointerEnter(PointerEventData eventData)
    {
        textMeshPro.color = hoverColor;
    }

    // Quand la souris quitte la zone du texte
    public void OnPointerExit(PointerEventData eventData)
    {
        textMeshPro.color = normalColor;
    }
}
