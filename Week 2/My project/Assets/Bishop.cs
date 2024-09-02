using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : MonoBehaviour
{

    void OnDrawGizmosSelected()
    {
        Vector3 startPosition = transform.position;

        Gizmos.color = Color.green;
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(7, 0, 7));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(-7, 0, 7));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(7, 0, -7));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(-7, 0, -7));
    }   
}