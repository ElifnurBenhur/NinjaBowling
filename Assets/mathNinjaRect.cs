using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCvSharp;


public class mathNinjaRect : MonoBehaviour
{
    GameManager gaMan;
    WebCamTexture webCamTexture;
    CascadeClassifier cascade;
    OpenCvSharp.Rect myFace;
    int fPosition = 0;




    // Start is called before the first frame update
    void Start()
    {
        gaMan = GameObject.FindObjectOfType<GameManager>();
        WebCamDevice[] devices = WebCamTexture.devices;
        webCamTexture = new WebCamTexture(devices[0].name);
        webCamTexture.Play();
        cascade = new CascadeClassifier("Assets/OpenCV+Unity/Demo/Face_Detector/haarcascade_frontalface_default.xml");




    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTexture = webCamTexture;
        Mat frame = OpenCvSharp.Unity.TextureToMat(webCamTexture);
        findNewFace(frame);
        //display(frame);
    }
    void OnGUI()
    {
        //Debug.Log(webCamTexture.GetPixel(50,50));

    }

    void findNewFace(Mat frame)
    {
        var faces = cascade.DetectMultiScale(frame, 1.1, 2, HaarDetectionType.ScaleImage); //!!!!
        if (faces.Length >= 1)
        {
            int x = faces[0].Right;
            int y = faces[0].Top;
          
           // Debug.Log("Yükseklik"+faces[0].Height);
            
            //Debug.Log("Genişlik"+faces[0].Width);
            //Debug.Log("Konum" + faces[0].Location);
            if (faces[0].Right < 285)
            {
                if (fPosition != 1&&fPosition!=0)
                {
                    gaMan.setLocChange(1);
                }
                else
                {
                    gaMan.setLocChange(0);
                }
                fPosition = 1;
                //Debug.Log("SOL");
            }
            if (faces[0].Right > 285)
            {
                if (fPosition != 2 && fPosition != 0)
                {
                    gaMan.setLocChange(2);
                }
                else
                {
                    gaMan.setLocChange(0);
                }
                
                fPosition = 2;
                //Debug.Log("SAĞ");
            }
           /* if (faces[0].Top < 150)
            {
                Debug.Log("YUKARI");
            }
            if (faces[0].Top >150)
            {
                Debug.Log("AŞAĞI");
            }*/
            myFace = faces[0];
        }
    }

    void display(Mat frame)
    {
        if (myFace != null)
        {
            frame.Rectangle(myFace, new Scalar(250, 0, 0, 0), 2);
        }
        Texture nText = OpenCvSharp.Unity.MatToTexture(frame);
        GetComponent<Renderer>().material.mainTexture = nText;
    }
}
