using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ParallaxSpriteLayerTint : MonoBehaviour
{
    public Color color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    void Start()
    {
        Tint();
    }

    void OnValidate()
    {
        Tint();
    }

    void Tint()
    {
        SpriteRenderer[] renderers = gameObject.GetComponentsInChildren<SpriteRenderer>();

        for(int i = 0; i < renderers.Count(); i++)
        {
            renderers[i].color = color;
        }
    }
}
