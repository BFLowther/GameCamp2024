using System.Collections;
using System.Collections.Generic;

using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(HillDuplicator))]
public class HillDuplicatorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        HillDuplicator gen = (HillDuplicator)target;

        if (GUILayout.Button("Generate"))
        {
            gen.PlaceHills();
        }
    }
}

public class HillDuplicator : MonoBehaviour
{
    public void PlaceHills()
    {        
        for (int i = 0; (transform.childCount > 0); i++)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }

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
