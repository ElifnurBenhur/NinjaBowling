using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cevap : MonoBehaviour
{
    private bool response = false;
    private gamePlayManager gaMan;
    // Start is called before the first frame update
    void Start()
    {
        gaMan = GameObject.FindObjectOfType<gamePlayManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "takeLocation" && !response)
        {
            response = true;
            gaMan.checkAns(response);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (response)
        {
            transform.Translate(Vector3.right);
        }
    }
}
