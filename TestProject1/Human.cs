namespace TestProject1;

public class Human
{
    public string name { get; set; }
    public int age { get; set; }
    public bool isWorker { get; set; }

    public Human(string name_, int age_, bool work)
    {
        name = name_;
        age = age_;
        isWorker = work;
    }

    public bool getWorkStatus()
    {
        return isWorker;
    }
}