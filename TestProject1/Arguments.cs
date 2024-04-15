namespace TestProject1;

public class Arguments : Side
{
    public int severity { get; set; }
    public int aggravating { get; set; }
    public int victims { get; set; }
    public int badIntentions { get; set; }
    public int safeFamily { get; set; }
    public bool accepted = false;
    
    public Arguments(int[] arr, Criminal criminal, Side side) : base(side.profession, side.stage, side)
    {   
        severity = arr[0];
        aggravating = arr[1];
        victims = arr[2];
        badIntentions = arr[3];
        safeFamily = arr[4];

        int score = GetFinallyMark();
        if (side.profession == "Advocat")
        {
            criminal.scoreAdv = score;
        }
        else
        {
            criminal.scoreProc = score;
        }
    }

    public int GetFinallyMark()
    {
        accepted = true;
        return severity * 3 + aggravating * 2 + victims * 4 + badIntentions + safeFamily / 2;
    }
}