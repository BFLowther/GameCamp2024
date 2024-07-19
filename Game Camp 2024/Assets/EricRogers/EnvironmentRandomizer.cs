using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentRandomizer : MonoBehaviour
{
    public bool uniformScale = true;
    public float scaleMin = 0.9f;
    public float scaleMax = 1.2f;
    public bool randomFlipX = true;
    void Awake()
    {
        float scale = Random.Range(scaleMin, scaleMax);

        transform.localScale = (uniformScale) ? new Vector3(scale, scale, 1.0f) : new Vector3(scale, Random.Range(scaleMin, scaleMax), 1.0f);

        if (randomFlipX)
        {
            if (gameObject.GetComponent<SpriteRenderer>())
            {
                SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

                spriteRenderer.flipX = (Random.Range(0.0f, 100.0f) > 50.0f);
            }
        }

    }
}
