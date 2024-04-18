using System;

namespace TestProject1;

public class Criminal : Human
{
    public int scoreProc = 0;
    public int scoreAdv = 0;
    public int countCrime = 0;
    public Crime crime { get; set; }
    public Crime crimeAdvokat { get; set; }
    
    public int Luck { get; set; }
    public bool Free { get; set; }
    public bool Vinoven = false;
    public Criminal(int luck_, Crime crime_, Human human) : base(human.name, human.age, human.isWorker)
    {
        Luck = luck_;
        crime = crime_;
        Free = false;
        TryAWayOut();
    }
    
    public void TryAWayOut()
    {
        Random r = new Random();
        if (r.Next(0, 101) + Luck >= 100)
        {
            Free = true;
            Vinoven = true;
        }
    }
    public bool getFree()
    {
        return Free;
    }
    public bool getVinoven()
    {
        return Vinoven;
    }
}