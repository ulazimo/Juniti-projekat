using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZloceZdravlje : MonoBehaviour
{
    public int MaksZdravlje;
    public int TrenutnoZdravlje;
    private CikicaStats cikicaStats;
    public int kolikoXpDaje;

    // Start is called before the first frame update
    void Start()
    {
        cikicaStats = FindObjectOfType<CikicaStats>();
        MaksZdravlje = 15 + cikicaStats.trenutniNivo * 5;
        TrenutnoZdravlje = MaksZdravlje;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TrenutnoZdravlje <= 0)
        {
            Destroy(gameObject);
            cikicaStats.PovecajXp(kolikoXpDaje);
        }
    }
    public void ZlocaRanjen(int kolikoRanjen)
    {
        TrenutnoZdravlje -= kolikoRanjen;
    }
    public void StaviMaksZdravlje()
    {
        TrenutnoZdravlje = MaksZdravlje;
    }
}
