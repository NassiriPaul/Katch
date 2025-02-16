using UnityEngine;

public class CardData
{
    public int Id;
    public string Name;
    public string Description;
    public Sprite Sprite;

    public CardData(int id, string name, string description, Sprite sprite)
    {
        Id = id;
        Name = name;
        Description = description;
        Sprite = sprite;
    }
}
