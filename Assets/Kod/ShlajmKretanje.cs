using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShlajmKretanje : MonoBehaviour
{
    public float brzinaKretanja;
    public float vremeNeKretanja;
    private float vremeNeKretanjaBrojac;
    public float vremeKretanja;
    private float vremeKretanjaBrojac;
    private Rigidbody2D ridzibadi;
    private bool kretanje;
    private Vector3 pravacKretanja;
    public float ReloadVreme;
    private bool reloadovanje;
    private GameObject cikica;

    // Start is called before the first frame update
    
    void Start()
    {
        ridzibadi = GetComponent<Rigidbody2D>();
        
        vremeKretanjaBrojac = Random.Range(0.7f * vremeKretanja, 1.4f * vremeKretanja);
        vremeNeKretanjaBrojac = Random.Range(0.7f * vremeNeKretanja, 1.4f * vremeNeKretanja);
    }

    // Update is called once per frame
    void Update()
    {
        if(kretanje)
        {
            ridzibadi.velocity = pravacKretanja;
            vremeKretanjaBrojac -= Time.deltaTime;
            if(vremeKretanjaBrojac<0f)
            {
                kretanje = false;
                vremeKretanjaBrojac = Random.Range(0.7f * vremeKretanja, 1.4f * vremeKretanja);

            }
        }
        else
        {
            ridzibadi.velocity = Vector2.zero;
            vremeNeKretanjaBrojac -= Time.deltaTime;
            if(vremeNeKretanjaBrojac<0f)
            {
                kretanje = true;
                vremeNeKretanjaBrojac = Random.Range(0.7f * vremeNeKretanja, 1.4f * vremeNeKretanja);
                pravacKretanja = new Vector3(Random.Range(-1f, 1f) * brzinaKretanja, Random.Range(-1f, 1f) * brzinaKretanja, 0f);
            }
        }
        if(reloadovanje)
        {
            ReloadVreme -= Time.deltaTime;
            if(ReloadVreme<0f)
            {
                Application.LoadLevel(Application.loadedLevel);
                cikica.SetActive(true);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D nesto)
    {
        /*if(nesto.gameObject.name=="Cikica")
        {
            nesto.gameObject.SetActive(false);
            reloadovanje = true;
            cikica = nesto.gameObject;
        }*/
    }
}
