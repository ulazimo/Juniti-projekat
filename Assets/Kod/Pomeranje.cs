using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pomeranje : MonoBehaviour
{

    public float brz_hodanja;
    private float trenutnaBrzina;

    private bool pomeraSe;
    public Vector2 poslednjePomeranje;
    private Rigidbody2D cikaridzitbadi;

    private Animator anime;
    private static bool cikicaPostoji;

    private bool napadanje = false;
    public float napadVreme;
    private float napadVremeBrojac;
    private float brojacZaSpawn = 0;

    public string pocetnaTacka;
    Vector2 pozicijaCike;
    // Start is called before the first frame update
    void Start()
    {
        pozicijaCike.x = transform.position.x;
        pozicijaCike.y = transform.position.y;
        anime = GetComponent<Animator>();
        cikaridzitbadi = GetComponent<Rigidbody2D>();
        if (!cikicaPostoji)
        {
            cikicaPostoji = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        pomeraSe = false;

        if (!napadanje)
        {
            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * brz_hodanja * Time.deltaTime, 0f, 0f));
                cikaridzitbadi.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * trenutnaBrzina, cikaridzitbadi.velocity.y);
                pomeraSe = true;
                poslednjePomeranje = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            }
            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * brz_hodanja * Time.deltaTime, 0f));
                cikaridzitbadi.velocity = new Vector2(cikaridzitbadi.velocity.x, Input.GetAxisRaw("Vertical") * trenutnaBrzina);
                pomeraSe = true;
                poslednjePomeranje = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            }
            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
                cikaridzitbadi.velocity = new Vector2(0f, cikaridzitbadi.velocity.y);
            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
                cikaridzitbadi.velocity = new Vector2(cikaridzitbadi.velocity.x, 0f);

            if (Input.GetKeyDown(KeyCode.Q))
            {
                napadVremeBrojac = napadVreme;
                napadanje = true;
                cikaridzitbadi.velocity = Vector2.zero;
                anime.SetBool("Napad", true);
            }
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.5f && Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.5f) //za dijagonalno pomeranje, jer ide brze
                trenutnaBrzina = brz_hodanja / Mathf.Sqrt(2);
            else
                trenutnaBrzina = brz_hodanja;
            
        }

        if (napadVremeBrojac>=0)
            napadVremeBrojac -= Time.deltaTime;

        if(napadVremeBrojac<=0)
        {
            napadanje = false;
            anime.SetBool("Napad", false);
        }

        anime.SetFloat("PomeranjeX", Input.GetAxisRaw("Horizontal"));
        anime.SetFloat("PomeranjeY", Input.GetAxisRaw("Vertical"));
        anime.SetBool("PomeraSe", pomeraSe);
        anime.SetFloat("PoslednjePomeranjeX", poslednjePomeranje.x);
        anime.SetFloat("PoslednjePomeranjeY", poslednjePomeranje.y);
    }
}
