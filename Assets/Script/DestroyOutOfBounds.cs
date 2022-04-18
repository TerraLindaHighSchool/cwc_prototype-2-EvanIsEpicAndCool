﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///This stuff just destroys the object that is past the bounds that are created by the grounds.
/// </summary>
public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject); 
        } 
        else if (transform.position.z < lowerBound) 
        {
            Debug.Log("Game Over!");
            Destroy(gameObject); 
        }
    }
}