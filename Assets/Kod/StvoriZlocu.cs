using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StvoriZlocu : MonoBehaviour
{
    public GameObject zloca;
    private Vector3 pozicija;
    private float brojac = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        pozicija = this.gameObject.transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        brojac += Time.deltaTime;
        if(brojac>3f)
        {
            if (Random.Range(10, 20) > 15)
                pozicija.x += Random.Range(3, 5);
            else
                pozicija.x -= Random.Range(3, 5);

            if (Random.Range(10, 20) > 15)
                pozicija.y += Random.Range(3, 5);
            else
                pozicija.y -= Random.Range(3, 5);
            Instantiate(zloca, pozicija, Quaternion.identity);
            pozicija = this.gameObject.transform.position;
            brojac -= 3f;
        }
    }
}
