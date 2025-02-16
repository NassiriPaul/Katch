using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardWrestler : MonoBehaviour
{
    [Header("Références UI")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI forceText;
    public TextMeshProUGUI vitesseText;
    public TextMeshProUGUI wowText;

    [Header("Valeurs par défaut")]
    public string defaultName;
    public int defaultForce;
    public int defaultVitesse;
    public int defaultWow;

    private string nom;
    private int force;
    private int vitesse;
    private int wow;

    private void updateCard()
    {
        nameText.text = nom;
        forceText.text = force.ToString();
        vitesseText.text = vitesse.ToString();
        wowText.text = wow.ToString();
    }

    public void Start()
    {
        nom = defaultName;
        force = defaultForce;
        vitesse = defaultVitesse;
        wow = defaultWow;
        updateCard();
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
        updateCard();
    }

    public void SetVitesse(int newVitesse)
    {
        vitesse = newVitesse;
        updateCard();
    }

    public void SetWow(int newWow)
    {
        wow = newWow;
        updateCard();
    }
}
