namespace TestProject1;

public class Prigovor
{
    public string name { get; set; }
    public bool isFree { get; set; }
    public bool Vinoven { get; set; }
    public Crime crime { get; set; }
    public bool betterCrime { get; set; }
    public int skolkoSidet { get; set; }

    public Prigovor(Criminal criminal, int score)
    {
        name = criminal.name;
        setPrigivor(criminal, score);
    }

    public void setPrigivor(Criminal criminal, int score)
    {
        if (criminal.sbejal)
        {
            criminal.Vinoven = true;
            criminal.Free = true;
            skolkoSidet = 100;
        }
        else if (score <= 0)
        {
            criminal.crime = Crime.innocent;
            criminal.Vinoven = false;
            criminal.Free = true;
            skolkoSidet = 0;
        }
        else if (score <= 3)
        {
            if (criminal.crimeAdvokat != Crime.innocent)
            {
                criminal.crime = criminal.crimeAdvokat;
                betterCrime = true;
            }
            criminal.Vinoven = true;
            criminal.Free = false;
            skolkoSidet = score;
        }
        else
        {
            criminal.Vinoven = true;
            criminal.Free = false;
            skolkoSidet = score;
        }
        crime = criminal.crime;
        isFree = criminal.getFree();
        Vinoven = criminal.getVinoven();
    }
}