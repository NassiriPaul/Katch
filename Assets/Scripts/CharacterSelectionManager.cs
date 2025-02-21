using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionManager : MonoBehaviour
{
    public CardWrestler cardPrefab;
    public CardWrestlerData[] wrestlerDatas;

    void Start()
    {
        if (wrestlerDatas.Length > 0)
        {
            cardPrefab.SetWrestlerData(wrestlerDatas[0]);
        }
    }

    public void OnCharacterButtonClicked(int characterIndex)
    {
        if (characterIndex >= 0 && characterIndex < wrestlerDatas.Length)
        {
            cardPrefab.SetWrestlerData(wrestlerDatas[characterIndex]);
        }
    }
}
