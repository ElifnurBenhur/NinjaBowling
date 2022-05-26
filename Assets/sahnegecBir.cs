using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sahnegecBir : MonoBehaviour
{
   

    public void NextScene(int sID)
    {
        SceneManager.LoadScene(sID);
    }

}
