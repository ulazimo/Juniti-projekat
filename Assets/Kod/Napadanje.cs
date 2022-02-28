using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Napadanje : MonoBehaviour
{
    public int kolikoRanjen;
    public GameObject Burst;
    public Transform tackaUdara;
    public GameObject brojRanjen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D nesto)
    {
        if(nesto.gameObject.tag=="Zloca")
        {
            nesto.gameObject.GetComponent<ZloceZdravlje>().ZlocaRanjen(kolikoRanjen);
            Instantiate(Burst, tackaUdara.position, tackaUdara.rotation);
            var klon = (GameObject)Instantiate(brojRanjen, tackaUdara.position, Quaternion.Euler(Vector3.zero));
            klon.GetComponent<LeteciBrojevi>().brojRanjen = kolikoRanjen;
        }
    }
}
