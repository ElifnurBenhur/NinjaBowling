using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topRight : Circle
{

        //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":13.2623929977417,"y":2.6976914405822756,"z":3.0084588527679445},"rotation":{"x":-0.7069991827011108,"y":0.012340744957327843,"z":0.012340746819972992,"w":0.7069990634918213},"scale":{"x":100.0,"y":100.00001525878906,"z":100.00003051757813}}   
    
    public void toUp()
    {
        transform.position=new Vector3(13.2624f,2.6999f, 2.5f);
    }
   public void toRight()
    {
        transform.position = new Vector3(12.8424f, 2.6999f, 2.5f);
    }
}
