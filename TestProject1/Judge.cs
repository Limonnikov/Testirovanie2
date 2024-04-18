namespace TestProject1;

public class Judge : Human
{
    public int stage { get; set; }
    public Judge(int stage_, Human human) : base(human.name, human.age, human.isWorker)
    {
        stage = stage_;
        if (stage > age - 22)
        {
            stage = age - 22;
        }
    }

    public void searchDB(Criminal criminal, DB db)
    {
        criminal.countCrime = db.returnCountCrime(criminal);
    }

    public Prigovor getPrigivor(Criminal criminal, DB db)
    {
        searchDB(criminal, db);
        int result = criminal.scoreAdv + criminal.scoreProc;

        if (criminal.countCrime == 0) result -= 10;
        else if (criminal.countCrime == 1) result += 5;
        else if (criminal.countCrime == 2) result += 10;
        else result += 15;

        result -= criminal.Luck / 2;

        Prigovor prigovor = new Prigovor(criminal, result);
        return prigovor;
    }
}