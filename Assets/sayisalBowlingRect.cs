using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCvSharp;


public class sayisalBowlingRect : MonoBehaviour
{
    private takeLocation takeloc;
    private WebCamTexture webCamTexture;
    private CascadeClassifier cascade;
    private OpenCvSharp.Rect myFace;




    // Start is called before the first frame update
    void Start()
    {

        takeloc = GameObject.FindObjectOfType<takeLocation>();
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
          // Debug.Log(faces[0].Location);
            int x = faces[0].Right;
            int y = faces[0].Top;
            takeloc.UpdateLocation(x,y);
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

