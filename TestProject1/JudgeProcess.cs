namespace TestProject1;

public class JudgeProcess
{
    public Prigovor prigovor { get; set; }
    public JudgeProcess(int stage_a, int stage_p, int stage_j, string crimeName, int luck, Crime crime, 
                        Crime adv, int a1, int a2, int a3, int a4, int a5, 
                        int d1, int d2, int d3, int d4, int d5)
    {
        var Gena = new Human("Gena", 45, true);
        var Cheburashka = new Human("Cheburashka", 24, true);
        var Shepoklyak = new Human("Shepoklyak", 63, true);
        var Krisa = new Human(crimeName, 18, true);

        var criminal = new Criminal(luck, crime, Krisa);
        var advocat = new Side("Advocat", stage_a, Gena);
        var procuror = new Side("Procuror", stage_p, Cheburashka);
        var judge = new Judge(stage_j, Shepoklyak);
        var db = new DB();
        
        criminal.TryAWayOut();

        var defense = advocat.GetArguments(criminal, adv, a1, a2, a3, a4, a5);
        var attacking = procuror.GetArguments(criminal, crime, d1, d2, d3, d4, d5);

        prigovor = judge.getPrigivor(criminal, db);
    }

    public string PrigovorSummury()
    {
        if (prigovor.isFree && prigovor.Vinoven)
            return "Подсудимый сбежал!";
        else if (prigovor.isFree && !prigovor.Vinoven)
            return "Подсудимый полностью оправдан. Полный успех адвоката";
        else if (prigovor.betterCrime)
            return "Подсудимый виновен, но приговор смягчен. Какой никакой, но успех адвоката";
        else 
            return "Подсудимый наказан по всей строгости. Провал адвоката";
    }
}