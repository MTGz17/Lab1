using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        Vector3 startPosition = transform.position;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(0, 0, 7));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(0, 0, -7));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(7, 0, 0));
        Gizmos.DrawLine(startPosition, startPosition + new Vector3(-7, 0, 0));
    }
}