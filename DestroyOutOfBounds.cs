using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBorderLine = 23;
    private float lowBorderLine = -6.5f;

    void Start()
    {
    }

    void Update()
    {
        if (transform.position.z > topBorderLine)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= lowBorderLine)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
