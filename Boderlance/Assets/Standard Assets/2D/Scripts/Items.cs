﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
    private int id;
    private Rigidbody2D rb;
    private Vector2 splosion = new Vector2(Random.Range(0.1f, 0.5f), Random.Range(0.1f, 0.5f));
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = splosion;
    }
            
    

    
}
	
