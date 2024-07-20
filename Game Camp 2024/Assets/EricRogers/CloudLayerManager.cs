using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudLayerManager : MonoBehaviour
{
    public float speed = 20.0f;
    private float max = float.MinValue;
    private float min = float.MaxValue;


    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform childTransform = transform.GetChild(i);

            min = Mathf.Min(min, childTransform.localPosition.x);

            max = Mathf.Max(max, childTransform.localPosition.x);
        }
    }

    void Update()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform childTransform = transform.GetChild(i);

            childTransform.localPosition -= new Vector3(speed*Time.deltaTime, 0.0f, 0.0f);

            if (childTransform.localPosition.x < min)
                childTransform.localPosition = new Vector3(max, childTransform.localPosition.y, childTransform.localPosition.z);
        }
    }
}
