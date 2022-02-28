using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CikicaStats : MonoBehaviour
{
    public int trenutniNivo;
    public int trenutniExp;
    public int[] kolikoZaLvlUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(trenutniExp>=kolikoZaLvlUp[trenutniNivo])
        {
            trenutniNivo++;
            FindObjectOfType<CikicaZdravlje>().StaviMaksZdravlje();
        }

    }
    public void PovecajXp(int zaKoliko)
    {
        trenutniExp += zaKoliko;
    }
}
