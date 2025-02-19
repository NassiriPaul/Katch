using UnityEngine;

public class BoardHandler : MonoBehaviour
{                  
    [SerializeField] private int width=1;
    [SerializeField] private int height=1;
    [SerializeField] private GameObject Board1;
    [SerializeField] private GameObject Board2;
    [SerializeField] private GameObject Slot;
    [SerializeField] private GameObject Line;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i=0;i<height;i++)
        {
            GameObject line=Instantiate(Line,new Vector3(0,0,0),Quaternion.identity);
            for(int j=0;j<width;j++)
            {
                GameObject tmp = Instantiate(Slot, new Vector3(), Quaternion.identity);
                tmp.transform.SetParent(line.transform, false);
            }
            line.transform.SetParent(Board1.transform,false);
        }

        for (int i = 0; i < height; i++)
        {  
            GameObject line=Instantiate(Line,new Vector3(0,0,0),Quaternion.identity);
            for(int j=0;j<width;j++)
            {

                GameObject tmp = Instantiate(Slot, new Vector3(), Quaternion.identity);
                tmp.transform.SetParent(line.transform, false);
            }
            line.transform.SetParent(Board2.transform,false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
