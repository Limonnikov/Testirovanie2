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

    public void getPrigivor()
    {
        
    }
}