using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DebugExtensions
{
    public static void DrawSphere(Vector3 position, float size = 0.5f, float duration = 5f)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj.transform.localScale = Vector3.one * size;
        GameObject.Destroy(obj, duration);
    }

    public static void DrawSphere(Vector3 position, Color color, float size = 0.5f, float duration = 5f)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        obj.transform.localScale = Vector3.one * size;
        if(obj.TryGetComponent( out MeshRenderer renderer))
        {
            renderer.material.SetColor("_BaseColor", color);
        }
        GameObject.Destroy(obj, duration);
    }
}
