using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ResetSelected : MonoBehaviour
{
    [MenuItem("GameObject/Reset Object", false, 0)]
    
    private static void Reset()
    {

        GameObject selectedObject = Selection.activeGameObject;

            selectedObject.transform.position = new Vector3(0, 0, 0);

            Rigidbody rb = selectedObject.GetComponent<Rigidbody>();

                Object.DestroyImmediate(rb);
            
    }
}