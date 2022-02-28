using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CikicaZdravlje : MonoBehaviour
{
    public int cikicaMaksZdravlje;
    public int cikicaTrenutnoZdravlje;
    

    // Start is called before the first frame update
    void Start()
    {
        cikicaTrenutnoZdravlje = cikicaMaksZdravlje;
    }

    // Update is called once per frame
    void Update()
    {
        if(cikicaTrenutnoZdravlje<=0)
        {
            gameObject.SetActive(false);
        }
        
    }
    public void CikicaRanjen(int kolikoRanjen)
    {
        cikicaTrenutnoZdravlje -= kolikoRanjen;
    }
    public void StaviMaksZdravlje()
    {
        cikicaMaksZdravlje = 100 + FindObjectOfType<CikicaStats>().trenutniNivo * 20;
        cikicaTrenutnoZdravlje = cikicaMaksZdravlje;
    }
}
