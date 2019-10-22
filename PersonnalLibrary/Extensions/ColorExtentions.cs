using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorExtentions
{

    public static Color GetRandomDColorBright
    {
        get { return new Color(Random.Range(.4f, 1), Random.Range(.4f, 1), Random.Range(.4f, 1)); }
    }
    public static Color GetRandomColor
    {
        get { return new Color(Random.Range(.1f, .9f), Random.Range(.1f, .9f), Random.Range(.1f, .9f)); }
    }

    public static Color RandomColorDim
    {
        get { return new Color(Random.Range(.4f, .6f), Random.Range(.4f, .8f), Random.Range(.4f, .8f)); }
    }

    public static void SetAlpha(this Color color, float a)
    {
        color = new Color(color.r, color.g, color.b, a);
    }

    public static void SetAlpha(this SpriteRenderer renderer, float alpha)
    {
        var color = renderer.color;
        color = new Color(color.r, color.g, color.b, alpha);
        renderer.color = color;
    }

    public static string ToHex(this Color color)
    {
        return string.Format("#{0:X2}{1:X2}{2:X2}", (int)(color.r * 255), (int)(color.g * 255), (int)(color.b * 255));
    }
}
