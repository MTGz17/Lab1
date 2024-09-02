using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{

    void OnDrawGizmosSelected()
    {
 
        Vector3[] knightMoves = new Vector3[]
        {
            new Vector3(2 , 0, 1),
            new Vector3(2 , 0, -1),
            new Vector3(-2 , 0, 1),
            new Vector3(-2 , 0, -1),
            new Vector3(1 , 0, 2),
            new Vector3(1 , 0, -2),
            new Vector3(-1 , 0, 2),
            new Vector3(-1 , 0, -2)
        };
        
        foreach (var move in knightMoves)
        {
            Gizmos.color = Color.yellow;
            Vector3 endPoint = transform.position + move;
            Gizmos.DrawLine(transform.position, endPoint);
        }
    }
}