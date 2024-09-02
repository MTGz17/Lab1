using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SpriteRenderer))]
public class Handle : Editor
{
    private void OnSceneGUI()
    {
        SpriteRenderer spriteRenderer = (SpriteRenderer)target;
        Sprite sprite = spriteRenderer.sprite;

        if (sprite == null)
            return;

        Bounds bounds = spriteRenderer.bounds;

        Handles.color = Color.green;
        Handles.DrawWireCube(bounds.center, bounds.size);
    }
}