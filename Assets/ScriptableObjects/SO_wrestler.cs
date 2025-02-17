using UnityEngine;


[CreateAssetMenu(fileName = "CardWrestlerData", menuName = "ScriptableObjects/WrestlerScriptableObject")]
public class CardWrestlerData : ScriptableObject
{
    public string wrestlerNom;
    public Sprite wrestlerSprite;
    public int force;
    public int vitesse;
    public int wow;
    public int health;
}