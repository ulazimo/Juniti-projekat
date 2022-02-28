using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MestoKadIzadje : MonoBehaviour
{

    private Pomeranje cikica;
    private Kamera kamera;
    public Vector2 pocetniPravac;

    public string imePocetneTacke;
    // Start is called before the first frame update
    void Start()
    { 
        cikica = FindObjectOfType<Pomeranje>();
        if (cikica.pocetnaTacka == imePocetneTacke)
        {
            cikica.transform.position = new Vector3(transform.position.x, transform.position.y, cikica.transform.position.z);
            cikica.poslednjePomeranje = pocetniPravac;
            kamera = FindObjectOfType<Kamera>();
            kamera.transform.position = new Vector3(transform.position.x, transform.position.y, kamera.transform.position.z);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
