using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeLocation : MonoBehaviour
{
    

    
    // Start is called before the first frame update
    void Start()
    {
       gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = true;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        Vector3 pos = transform.position;

    }
    // Update is called once per frame
    public void UpdateLocation(int x, int y)
    {
        
        float xf = (float)(((x / 63.33)*(-1))+5.71);
        float yf = (float)((y / 41.11)-3.91);
        string msg = xf.ToString() + "," + yf.ToString();
        transform.position = new Vector3(xf, 1,yf);
        Debug.Log(msg);
            
    }
}
