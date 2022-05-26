using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downRight : Circle
{
  
        //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":13.260393142700196,"y":2.6999998092651369,"z":2.830000162124634},"rotation":{"x":0.4911976456642151,"y":-0.5086500644683838,"z":-0.5086501240730286,"w":-0.4911976456642151},"scale":{"x":100.0,"y":100.0,"z":100.00003051757813}}
    
    public void toDown()
    {
        transform.position = new Vector3(13.2604f,2.6999f,3.4f);
    }
    public void toRight()
    {
        transform.position = new Vector3(12.8404f, 2.6999f, 3.4f);
    }
}
