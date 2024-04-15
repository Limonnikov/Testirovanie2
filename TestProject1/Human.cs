namespace TestProject1;

public class Human
{
    public string name { get; set; }
    public int age { get; set; }
    public bool isWorker = true;
    
    public Human(string name_, int age_, bool work)
    {
        name = name_;
        age = age_;
        isWorker = work;
    }

    public void changeWorkStatus()
    {
        isWorker = !isWorker;
    }
    public bool getWorkStatus()
    {
        return isWorker;
    }

    public Side CreateSide(string prof, int stage)
    {
        Human human = this as Human;
        Side side = new Side(prof, stage,human);

        return side;
    }
}