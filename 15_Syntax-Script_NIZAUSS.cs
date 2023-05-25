using System;

static void Main(string[] args)
{


    // ARRAY BEFEHL, SPAWNT ALLE 5 SEKUNDEN EIN NEUES MÜLL-OBJEKT

    string[] muellgegenstaende = { "Plastikflasche", "Aludose", "Papiertüte", "Karton", "Glasscherbe" };

    while (true)
    {
        // Zufälligen Müllgegenstand auswählen
        Random rand = new Random();
        int index = rand.Next(0, muellgegenstaende.Length);
        string muell = muellgegenstaende[index];

        // Müllgegenstand fallen lassen
        Console.WriteLine($"Ein {muell} fällt vom Himmel!");

        // 5 Sekunden warten
        Thread.Sleep(5000);
    }



    // Überprüfen, ob Müll richtig entsorgt wurde
    bool richtigEntsorgt = false;


    if (muell == "Plastikflasche" && muellEimer == "plastik")
    {
        richtigEntsorgt = true;
    }
    else if (muell == "Aludose" && muellEimer == "alu")
    {
        richtigEntsorgt = true;
    }
    else if (muell == "Papiertüte" && muellEimer == "papier")
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

    // IF/ELSE BEFEHL, WENN DER MÜLL RICHTIG ENTSORGT WIRD, ERKLINGT EIN POSITIVER SOUND.
    // WENN ER FALSCH ENTSORGT WURDE, EIN NEGATIVER SOUND

    if (richtigEntsorgt)
    {
        positiverSound.play;
    }
    else
    {
        negativerSound.play;
    }







    // WHILE BEFEHL. WENN ÜBER 10 MÜLLOBJEKTE EXISTIEREN, WIRD KEIN MÜLL MEHR GESPAWNT


    int muellCount = 0;

    while (muellCount < 10)
    {

        Random rand = new Random();
        int index = rand.Next(0, muellgegenstaende.Length);
        string muell = muellgegenstaende[index];
    }
}
}
