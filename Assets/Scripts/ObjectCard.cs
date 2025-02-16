using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ObjectCard : MonoBehaviour
{

    [Header("Références UI")]
    public TextMeshProUGUI nameText;
    public Image cardIllustration;
    public TextMeshProUGUI descriptionText;

    [Header("Valeurs par défaut")]
    public string defaultName;
    public Sprite defaultIllu;
    public int defaultDescription;

    private Sprite illu;
    private string nom;
    private string description;
    private int id;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void SetupCard(string nameCard, Sprite illuCard,  string descriptionCard, int idCard)
    {
        Debug.Log("jere");
        this.nom = nameCard;
        this.illu = illuCard;
        this.description = descriptionCard;
        this.id = idCard;
        UpdateCardUI();
    }
     // Met à jour l'affichage UI
    private void UpdateCardUI()
    {
        if (nameText != null) nameText.text = nom;
        if (descriptionText != null) descriptionText.text = description;
        if (cardIllustration != null) cardIllustration.sprite = illu;
    }

    // Getter et Setter pour l'illustration
    public Sprite GetIllustration()
    {
        return illu;
    }

    public void SetIllustration(Sprite newIllustration)
    {
        illu = newIllustration;
        if (cardIllustration != null)
        {
            cardIllustration.sprite = illu;
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
