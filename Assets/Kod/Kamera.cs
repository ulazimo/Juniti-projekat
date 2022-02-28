using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public GameObject pratiMetu;
    private Vector3 pozicijaMete;
    public float brzinaKamere;
    private static bool kameraPostoji;
    // Start is called before the first frame update
    void Start()
    {
        if (!kameraPostoji)
        {
            kameraPostoji = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
            Destroy(gameObject);
    }
    

    // Update is called once per frame
    void Update()
    {
        pozicijaMete = new Vector3(pratiMetu.transform.position.x, pratiMetu.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, pozicijaMete, brzinaKamere * Time.deltaTime);
    }
}
