﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasureroController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Invoca el destructor del objeto que colisiona
        Destroy(collision.gameObject);
    }
}
