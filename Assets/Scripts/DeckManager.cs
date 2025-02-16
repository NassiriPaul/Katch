using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class DeckManager : MonoBehaviour
{
    [Header("Références UI")]
    public GameObject cardPrefab; // Préfabriqué de la carte
    public Transform dropContainer; // Conteneur où s'affichent les cartes piochées
    public TextAsset cardDataCSV; // Fichier CSV contenant les données des cartes

    private List<CardData> deck = new List<CardData>(); // Deck caché
    private Dictionary<int, CardData> cardDatabase = new Dictionary<int, CardData>(); // Base de données des cartes

    void Start()
    {
        LoadCardDatabase();
        AddCard(1);
        AddCard(2);
        AddCard(3);
    }

    // Charge les cartes depuis un CSV
    private void LoadCardDatabase()
    {
        if (cardDataCSV == null)
        {
            Debug.LogError("Le fichier CSV n'est pas assigné !");
            return;
        }

        string[] data = cardDataCSV.text.Split('\n');

        Debug.Log($"Nombre de lignes dans le CSV (y compris l'en-tête) : {data.Length}");

        for (int i = 0; i < data.Length; i++) // On commence à 1 pour éviter l'entête
        {
            if (string.IsNullOrWhiteSpace(data[i])) 
            {
                Debug.LogWarning($"Ligne {i} vide ou incorrecte, on passe.");
                continue;
            }

            string[] row = data[i].Split(',');

            if (row.Length < 4)
            {
                Debug.LogWarning($"Ligne {i} incorrecte (colonnes insuffisantes) : {data[i]}");
                continue;
            }

            Debug.Log($"Ligne {i} analysée : {data[i]}");

            int id;
            if (!int.TryParse(row[0], out id))
            {
                Debug.LogError($"Impossible de convertir l'ID en int à la ligne {i} : {row[0]}");
                continue;
            }

            string name = row[1];
            string description = row[2];
            string spritePath = "Sprites/objects/" + row[3].Trim(); // Trim pour éviter les espaces invisibles
            Sprite sprite = Resources.Load<Sprite>(spritePath);

            if (sprite == null)
            {
                Debug.LogError($"Image non trouvée : {spritePath}");
            }

            CardData newCard = new CardData(id, name, description, sprite);
            cardDatabase.Add(id, newCard);

            Debug.Log($"Carte ajoutée : ID={id}, Nom={name}, Image={(sprite != null ? "OK" : "NON TROUVÉE")}");
        }

        Debug.Log($"Chargement terminé. Nombre total de cartes dans la base : {cardDatabase.Count}");
    }


    // Ajoute une carte au deck à partir de son ID
    public void AddCard(int id)
    {
        if (cardDatabase.ContainsKey(id))
        {
            deck.Add(cardDatabase[id]);
        }
        else
        {
            Debug.LogWarning("ID de carte non trouvé : " + id);
        }
    }

    // Mélange le deck
    public void ShuffleDeck()
    {
        System.Random rng = new System.Random();
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            CardData value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }

    public ObjectCard DrawCard()
    {
        Debug.Log("here");
        if (deck.Count > 0)
        {
            CardData drawnCard = deck[0]; // Prend la première carte
            deck.RemoveAt(0); // Retire la carte du deck

            // Instancier la carte et la placer dans DropContainer
            GameObject newCard = Instantiate(cardPrefab, dropContainer);
            ObjectCard objectCard = newCard.GetComponent<ObjectCard>();
            objectCard.SetupCard(drawnCard.Name, drawnCard.Sprite, drawnCard.Description, drawnCard.Id);
            Debug.Log("Carte piochée : " + drawnCard.Name);
            return objectCard;
            
        }
        else
        {
            Debug.Log("Le deck est vide !");
            return null;
        }
    }

}
