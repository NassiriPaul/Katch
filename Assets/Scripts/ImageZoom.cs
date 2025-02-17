using UnityEngine;

public class ImageZoom : MonoBehaviour
{
    public float zoomSpeed = 1.0f; // Vitesse du zoom
    public float maxScale = 1.2f; // Taille maximale
    public float minScale = 0.8f; // Taille minimale

    private RectTransform rectTransform;
    private float scaleDirection = 1.0f; // Indique si on zoome ou dézoome

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Change l'échelle en fonction de la direction
        float scaleChange = scaleDirection * zoomSpeed * Time.deltaTime;
        Vector3 newScale = rectTransform.localScale + new Vector3(scaleChange, scaleChange, 0);

        // Vérifie les limites
        if (newScale.x > maxScale || newScale.x < minScale)
        {
            scaleDirection *= -1; // Inverse la direction du zoom
            newScale = new Vector3(
                Mathf.Clamp(newScale.x, minScale, maxScale),
                Mathf.Clamp(newScale.y, minScale, maxScale),
                1
            );
        }

        rectTransform.localScale = newScale;
    }
}
