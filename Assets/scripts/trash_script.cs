using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = System.Random;

public class trash_script : MonoBehaviour
{


    public AudioSource positiverSound;

    public AudioSource negativerSound;
    
    private string muell;
    private string muellEimer;


    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    object Update()
    {
        // ARRAY BEFEHL, SPAWNT ALLE 5 SEKUNDEN EIN NEUES M�LL-OBJEKT

        string[] muellgegenstaende = { "Plastikflasche", "Aludose", "Papiert�te", "Karton", "Glasscherbe" };

        while (true)
        {
            // Zuf�lligen M�llgegenstand ausw�hlen
            Random rand = new Random();
            int index = rand.Next(0, muellgegenstaende.Length);
            string muell = muellgegenstaende[index];

            // M�llgegenstand fallen lassen
            Console.WriteLine($"Ein {muell} f�llt vom Himmel!");

            // 5 Sekunden warten
            Thread.Sleep(5000);
        }



        // �berpr�fen, ob M�ll richtig entsorgt wurde
        
        
        var richtigEntsorgt = false;


        if (muell == "Plastikflasche" && muellEimer == "plastik")
        {
            richtigEntsorgt = true;
        }
        else if (muell == "Aludose" && muellEimer == "alu")
        {
            richtigEntsorgt = true;
        }
        else if (muell == "Papiert�te" && muellEimer == "papier")
        {
            richtigEntsorgt = true;
        }
        else if (muell == "Karton" && muellEimer == "karton")
        {
            richtigEntsorgt = true;
        }
        else if (muell == "Glasscherbe" && muellEimer == "glas")
        {
            richtigEntsorgt = true;
        }

        // IF/ELSE BEFEHL, WENN DER M�LL RICHTIG ENTSORGT WIRD, ERKLINGT EIN POSITIVER SOUND.
        // WENN ER FALSCH ENTSORGT WURDE, EIN NEGATIVER SOUND

        if (richtigEntsorgt)
        {
            positiverSound.play;
        }
        else
        {
            negativerSound.play;
        }







        // WHILE BEFEHL. WENN �BER 10 M�LLOBJEKTE EXISTIEREN, WIRD KEIN M�LL MEHR GESPAWNT


        int muellCount = 0;

        while (muellCount < 10)
        {

            Random rand = new Random();
            int index = rand.Next(0, muellgegenstaende.Length);
            string muell = muellgegenstaende[index];
        }
    }




}
