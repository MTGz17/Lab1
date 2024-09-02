using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public bool drawDoubleMove = true;

    void OnDrawGizmosSelected()
    {
        Vector3 startPosition = transform.position;

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(0, 0, 1)); 

        if (transform.position.z >= -3.5f && transform.position.z <= -2.5f)
        {
            drawDoubleMove = true;
            if(drawDoubleMove == true)
            {
                Gizmos.DrawLine(startPosition, startPosition + new Vector3(0, 0, 2 * 1));
            }
        }

        Gizmos.color = Color.red;
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(1, 0, 1));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(-1, 0, 1));
    }
}