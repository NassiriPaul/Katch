using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject EnnemyArea;
    
   List <GameObject> cards =new List<GameObject>(); 
   void Start()
   {
       cards.Add(Card1); cards.Add(Card2);
   }
    public void OnClick(){
        for(int i=0;i<5;i++){
            GameObject playerCard=Instantiate(cards[Random.Range(0,2)],new Vector3(0,0,0),Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform,false);
        }
        for(int i=0;i<5;i++){
            GameObject playerCard=Instantiate(cards[Random.Range(0,2)],new Vector3(0,0,0),Quaternion.identity);
            playerCard.transform.SetParent(EnnemyArea.transform,false);
        }
    }
}
