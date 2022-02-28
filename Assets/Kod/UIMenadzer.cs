using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenadzer : MonoBehaviour
{
    public Slider zdravljeSlajder;
    public Text zdravljeText;
    public CikicaZdravlje cikicaZdravlje;
    private static bool UIpostoji;
    private CikicaStats cikicaStats;
    public Text lvlText;
    public Slider xpSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!UIpostoji)
        {
            UIpostoji = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
            Destroy(gameObject);
        cikicaStats = GetComponent<CikicaStats>();
    }

    // Update is called once per frame
    void Update()
    {
        zdravljeSlajder.maxValue = cikicaZdravlje.cikicaMaksZdravlje;
        zdravljeSlajder.value = cikicaZdravlje.cikicaTrenutnoZdravlje;
        zdravljeText.text = "HP: " + cikicaZdravlje.cikicaTrenutnoZdravlje + "/" + cikicaZdravlje.cikicaMaksZdravlje;

        xpSlider.maxValue = cikicaStats.kolikoZaLvlUp[cikicaStats.trenutniNivo] -
            cikicaStats.kolikoZaLvlUp[cikicaStats.trenutniNivo-1];

        xpSlider.value = cikicaStats.trenutniExp - cikicaStats.kolikoZaLvlUp[cikicaStats.trenutniNivo-1];

        lvlText.text = "LVL: " + cikicaStats.trenutniNivo + "    XP:" + (cikicaStats.trenutniExp - 
            cikicaStats.kolikoZaLvlUp[cikicaStats.trenutniNivo-1]) + "/" + 
            (cikicaStats.kolikoZaLvlUp[cikicaStats.trenutniNivo] - cikicaStats.kolikoZaLvlUp[cikicaStats.trenutniNivo-1]); 

    }
}
