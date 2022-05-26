using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamePlayManager : MonoBehaviour
{
    private Text oCountText;
    private int oCount = 10;
    private int hedef;
    private bool resp;
    private string resTxt;
    void Start()
    {
        resp = false;
        oCountText= GameObject.FindObjectOfType<Text>();

        hedef = Random.Range(0, 10);

    }
    void Update()
    {
         oCountText.text = "Hedef: "+hedef+" Kalan: " + oCount.ToString() +" == "+setAns(resp);
     }


    public void updateoCount(bool collied)
    {
        if (collied)
        {
            oCount--;

        }

    }
    public bool checkAns(bool cl)
    {
        if (cl)
        {
            resp = true;
        }
        return resp;
    }
    string setAns(bool rs)
    {
        if (rs)
        {
            if (oCount == hedef)
            {
                resTxt = "!!!DOGRU!!!";

            }
            else
            {
                resTxt = "_ULASAMADIN_";
            }
        }
        if (!rs)
        {
            resTxt = "...Yanit Bekliyor...";
        }
        return resTxt;
    }
   
}
