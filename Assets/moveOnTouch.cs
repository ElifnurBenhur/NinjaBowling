using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOnTouch : MonoBehaviour
{
   private  gamePlayManager gaM;
    private bool collied = false;

    void Start()
    {
        gaM = GameObject.FindObjectOfType<gamePlayManager>();
    }

  void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="takeLocation"&&!collied) {
            collied = true;
            gaM.updateoCount(collied);
            
                
            
        }
    }

    void Update()
    {
        
        if (collied) {
            transform.Translate(Vector3.forward);
        }
    }
}
