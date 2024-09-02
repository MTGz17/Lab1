using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{   
    IEnumerable<Vector3> GridPoints()
    {
        for(int x = -4; x < 4; x++)
        {
            for(int z = -4; z < 4; z++)
            {
                yield return new Vector3(x, 0, z);
            }
        }
    }

    void OnDrawGizmos()
    {
        foreach(var point in GridPoints())
        {
            Gizmos.DrawWireCube(point, new Vector3(1,0,1));
        }
    }
}