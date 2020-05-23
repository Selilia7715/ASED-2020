using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DIRECTION
{
    UP,
    RIGHT,
    LEFT,
    DOWN,
};

public class buttondoorGene : MonoBehaviour
{

    private int elenum;
    private float openspeed;
    private int activenum;              //押されたボタンと動くドアの番号

    public float openframe;


    public List<Someinfo> mylist = new List<Someinfo>();
    [System.Serializable]

    public class Someinfo
    {
        //オブジェクト&座標
        public GameObject doorobj;
        public GameObject buttonobj;
        public Vector3 doorpos;
        public Vector3 buttonpos;

        //スクリプト
        public Button buttonscr;
        public door doorscr;           

        public DIRECTION direction;
    }

    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 60;

        elenum = mylist.Count;

        for (int i = 0; i < elenum; i++)
        {
            mylist[i].doorobj = Instantiate(mylist[i].doorobj, new Vector3(mylist[i].doorpos.x, mylist[i].doorpos.y, 0), Quaternion.identity);
            mylist[i].buttonobj = Instantiate(mylist[i].buttonobj, new Vector3(mylist[i].buttonpos.x, mylist[i].buttonpos.y, 0), Quaternion.identity);
            //mylist[i].buttonobj.transform.parent = mylist[i].doorobj.transform;       //親子関係構築
            //ヒモ付け
            mylist[i].buttonscr = mylist[i].buttonobj.GetComponent<Button>();
            mylist[i].doorscr = mylist[i].doorobj.GetComponent<door>();

            //ここで識別番号代入
            mylist[i].buttonscr.discributton = i;
            mylist[i].doorscr.discridoor = i;


        }
    }

    private void Start()
    {
        openspeed = mylist[0].doorobj.transform.localScale.y / openframe;
        openspeed *= -1;

        //回転
        for (int i = 0; i < elenum; i++)
        {
            if (mylist[i].direction == DIRECTION.DOWN)
            {
                mylist[i].buttonobj.transform.Rotate(new Vector3(0, 0, 180));
            }

            if (mylist[i].direction == DIRECTION.RIGHT)
            {
                mylist[i].buttonobj.transform.Rotate(new Vector3(0, 0, 270));
            }

            if (mylist[i].direction == DIRECTION.LEFT)
            {
                mylist[i].buttonobj.transform.Rotate(new Vector3(0, 0, 90));
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < elenum; i++)
        {
            if (mylist[i].buttonscr.pushFg == true)
            {
                activenum = i;
                open();
                if (mylist[i].doorobj.transform.localScale.y <= 0.0f)
                {
                    mylist[i].buttonscr.pushFg = false;
                }
            }
        }
    }

    private void open()
    {
        mylist[activenum].doorobj.transform.localScale += new Vector3(0.0f, openspeed, 0.0f);
    }
}
