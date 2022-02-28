using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnistiVremenom : MonoBehaviour
{
    public float vreme;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vreme -= Time.deltaTime;
        if(vreme<=0)
            Destroy(gameObject);
    }
}
