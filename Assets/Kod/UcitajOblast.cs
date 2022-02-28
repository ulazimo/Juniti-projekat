using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UcitajOblast: MonoBehaviour
{
    public string gdeUlazi;

    public string izlaznaTacka;
    private Pomeranje cikicaPomeranje;
    // Start is called before the first frame update
    void Start()
    {
        cikicaPomeranje = FindObjectOfType<Pomeranje>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D drugi)
    {
        if(drugi.gameObject.name=="Cikica")
        {
            Application.LoadLevel(gdeUlazi);
            cikicaPomeranje.pocetnaTacka = izlaznaTacka;
        }
    }
}
