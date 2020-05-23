using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class door : MonoBehaviour
{
    public int discridoor;                 //識別番号
    public GameObject buttondoorGene;
    public buttondoorGene buttondoorscr;

    // Start is called before the first frame update
    void Start()
    {
        buttondoorGene = GameObject.Find("buttondoorGene");                 //工場見つける
        buttondoorscr = buttondoorGene.GetComponent<buttondoorGene>();      //スクリプト見つける
        //discridoorはGeneで代入
    }

    // Update is called once per frame
    void Update() { 
        

    }
}
   
