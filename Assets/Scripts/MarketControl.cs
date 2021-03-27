using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketControl : MonoBehaviour
{
    public GameObject UrunPrefab;
    public List<Texture> urunResimler;
    public GameObject panel;
    public float xPos = 50f;
    void Start()
    {
        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        for(int i=0;i<urunResimler.Count;i++)
        {
            
            GameObject urun= Instantiate(UrunPrefab,new Vector3(rectTransform.position.x,rectTransform.position.y,rectTransform.position.z),Quaternion.identity) as GameObject;
            urun.transform.parent = panel.transform;
            //UrunPrefab.transform.Translate(UrunPrefab.transform.parent.position.x + (xPos * i), 0f, 0f);

        }
    }

    
    void Update()
    {
        
    }
}
