namespace TestProject1;

public class Prigovor
{
    public string name { get; set; }
    public Crime crime { get; set; }
    public int skolkoSidet { get; set; }

    public Prigovor(Criminal criminal, int score)
    {
        name = criminal.name;
        setPrigivor(criminal, score);
    }

    public void setPrigivor(Criminal criminal, int score)
    {
        if (score <= 0)
        {
            criminal.crime = Crime.innocent;
            criminal.Vinoven = false;
            criminal.Free = true;
            skolkoSidet = 0;
        }
        else if (score <= 3)
        {
            if (criminal.crimeAdvokat != Crime.innocent)
                criminal.crime = criminal.crimeAdvokat;
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
    }
}