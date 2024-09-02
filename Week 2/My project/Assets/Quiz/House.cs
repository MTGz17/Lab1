using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{   

    //I drew it with a top-down view in mind because it wasn't specified that it had to go up in the y-axis
    //In case that it needs to go in the y-axis, just switch the y and z axis values

    Vector3[] points;
    
    void Start()
    {
        points = new Vector3[10]
        {
            new Vector3(0, 0, 0),
            new Vector3(0, 0, 2),
            new Vector3(0, 0, 2),
            new Vector3(2/2, 0, 2+(2/2)),
            new Vector3(2/2, 0, 2+(2/2)),
            new Vector3(2, 0, 2),
            new Vector3(2, 0, 2),
            new Vector3(2, 0, 0),
            new Vector3(2, 0, 0),
            new Vector3(0, 0, 0),
        };
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLineList(points);
    }
}