using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillDuplicator : MonoBehaviour
{
    void Awake()
    {
        SpriteRenderer sp = gameObject.GetComponent<SpriteRenderer>();
        float offset = 0.0f;

        for (int i = 0; i < 100; i++)
        {
            offset = i * sp.bounds.size.x;

            GameObject go = new GameObject();
            SpriteRenderer ren = go.AddComponent<SpriteRenderer>();
            ren.flipX = (i % 2 == 0);
            ren.sprite = sp.sprite;
            ren.sortingOrder = sp.sortingOrder;
            ren.sortingLayerID = sp.sortingLayerID;
            go.transform.position = transform.position + new Vector3(offset, 0.0f, 0.0f);
            go.transform.parent = transform;
        }
    }
}
