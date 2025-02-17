using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardWrestler : MonoBehaviour
{
    [Header("Données du catcheur")]
    public CardWrestlerData wrestlerData;

    [Header("Références UI")]
    public Image wrestlerImage;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI forceText;
    public TextMeshProUGUI vitesseText;
    public TextMeshProUGUI wowText;
    public Slider healthBar;


    private Sprite wrestlerSprite;
    private string nom;
    private int force;
    private int vitesse;
    private int wow;
    private int health;

    private void Awake()
    {
        updateDataCard();
        updateUICard();
    }

    private void updateDataCard(){
        if (wrestlerData != null)
        {
            wrestlerSprite = wrestlerData.wrestlerSprite;
            nom = wrestlerData.wrestlerNom;
            force = wrestlerData.force;
            vitesse = wrestlerData.vitesse;
            wow = wrestlerData.wow;
            health = wrestlerData.health;
        }
    }


    private void updateUICard()
    {
        wrestlerImage.sprite = wrestlerSprite;
        nameText.text = nom;
        forceText.text = force.ToString();
        vitesseText.text = vitesse.ToString();
        wowText.text = wow.ToString();
    }

    // Getters
    public string GetNom()
    {
        return nom;
    }

    public int GetForce()
    {
        return force;
    }

    public int GetVitesse()
    {
        return vitesse;
    }

    public int GetWow()
    {
        return wow;
    }

    // Setters
    public void SetForce(int newForce)
    {
        force = newForce;
        updateUICard();
    }

    public void SetVitesse(int newVitesse)
    {
        vitesse = newVitesse;
        updateUICard();
    }

    public void SetWow(int newWow)
    {
        wow = newWow;
        updateUICard();
    }
}
