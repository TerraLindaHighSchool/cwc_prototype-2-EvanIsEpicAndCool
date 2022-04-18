﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects if projectiles collide and destroys both.
/// </summary>
public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
    
}
