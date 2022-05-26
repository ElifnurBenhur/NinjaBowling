using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private Text msg;
    private topRight tR;
    private topLeft tL;
    private downLeft dL;
    private downRight dR;
    private int hedef;
    private int counter;
    private bool yatayHareket;
    private bool dikeyHareket;
    private string state;
    private string kesir;
    // Start is called before the first frame update
    void Start()
    {
        kesir = "BUTUN";
        state = "Bekliyor";
        yatayHareket = true;
        dikeyHareket = true;
        msg = GameObject.FindObjectOfType<Text>();
        tR = GameObject.FindObjectOfType<topRight>();
        tL = GameObject.FindObjectOfType<topLeft>();
        dR = GameObject.FindObjectOfType<downRight>();
        dL = GameObject.FindObjectOfType<downLeft>();
        hedef = Random.Range(1,3);
        counter = 0;
        if (hedef == 1)
        {
            kesir = "Yarim";
            hedef = 2;
        }
        if (hedef == 2)
        {
            kesir = "Ceyrek";
            hedef = 4;
        }
    }
    void Update()
    {
        if ((counter == 1 && hedef == 2)||(counter==2&&hedef==4))
        {
            state = "!!!Basardin!!!";
            Invoke("delAct", 10f);
           
        }
        msg.text = "Hedef: 1/"  + hedef + kesir + "Durum:"+state ;
        if (counter == 1&&dikeyHareket)
        {
            tR.toUp();
            tL.toUp();
            dL.toDown();
            dR.toDown();
          
            dikeyHareket = false;
        }
        if (counter == 2&&yatayHareket)
        {
            tR.toRight();
            dR.toRight();
            tL.toLeft();
            dL.toLeft();

            yatayHareket = false;
        }
    }
    // Update is called once per frame
   public void setLocChange(int a)
    {
        if (a == 0)
        {
            Debug.Log("Hareket YOK!!");
        }
        if (a == 1)
        {
            Debug.Log("Sola Hareket");
            counter++;
        }
        if (a == 2)
        {
            Debug.Log("Saga Hareket");
            counter++;
        }
    }

    public void delAct()
    {
        SceneManager.LoadScene(3);
    }

}
