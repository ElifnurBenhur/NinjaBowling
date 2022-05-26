using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downLeft : Circle
{
   
        //UnityEditor.TransformWorldPlacementJSON:{"position":{"x":13.260000228881836,"y":2.6999998092651369,"z":2.8899588584899904},"rotation":{"x":0.012340690940618515,"y":0.7069991230964661,"z":0.7069990634918213,"w":-0.01234069187194109},"scale":{"x":100.0001220703125,"y":100.00005340576172,"z":100.00006103515625}}
    
    public void toDown()
    {
        transform.position = new Vector3(13.26f,2.2999f,3.4f);
    }
    public void toLeft()
    {
        transform.position = new Vector3(13.76f, 2.2999f, 3.4f);
    }
}
