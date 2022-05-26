using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topLeft : Circle
{
   
        //UnityEditor.TransformWorldPlacementJSON:{ "position":{ "x":13.2623929977417,"y":2.6999998092651369,"z":3.0584588050842287},"rotation":{ "x":0.5086500644683838,"y":0.4911976158618927,"z":0.4911975860595703,"w":-0.5086501240730286},"scale":{ "x":100.0000228881836,"y":100.0000228881836,"z":100.00003051757813} }
    

    public void toUp()
    {
        transform.position=new Vector3(13.2624f,2.6999f,2.5f);
    }
    public void toLeft()
    {
        transform.position = new Vector3(13.7624f, 2.6999f, 2.5f);
    }
}
