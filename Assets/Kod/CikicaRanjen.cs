﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CikicaRanjen : MonoBehaviour
{
    public int kolikoRanjen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D nesto)
    {
        if(nesto.gameObject.name=="Cikica")
        {
            nesto.gameObject.GetComponent<CikicaZdravlje>().CikicaRanjen(kolikoRanjen);
            
        }
    }
}
