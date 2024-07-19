using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxManager : MonoBehaviour
{
    public List<ParallaxLayer> layers;
    public Transform target;
    private Transform m_lastPosition;

    void Start()
    {
        if (target == null)
            return;
        
        m_lastPosition = target;
    }

    void Update()
    {
        if (target == null)
            return;
        
        float deltaX = m_lastPosition.position.x - target.position.x;

        for(int i = 0; i < layers.Count; i++)
        {
            GameObject layerObject = layers[i].target;

            layerObject.transform.position += new Vector3(layers[i].movementSpeed * deltaX, 0.0f, 0.0f);
        }
        
        m_lastPosition = target;
    }
}
