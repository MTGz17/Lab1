using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        Vector3 startPosition = transform.position;

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(0, 0, 1)); 
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(0, 0, -1)); 
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(1, 0, 0)); 
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(-1, 0, 0)); 
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(1, 0, 1));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(-1, 0, 1));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(1, 0, -1));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(-1, 0, -1));
    }
}