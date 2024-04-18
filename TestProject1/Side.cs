namespace TestProject1;

public class Side : Human // сторона защиты (адвокат) или сторона нападания (прокурор)
{
    public string profession { get; set; }
    public int stage { get; set; }

    public Side(string profession_, int stage_, Human human) : base(human.name, human.age, human.isWorker)
    {
        profession = profession_;
        if (stage_ <= age - 22)
            stage = stage_;
        else
            stage = 0;

    }
    
    public Arguments GetArguments(Criminal criminal, Crime crime, int a, int b, int c, int d, int e)
    {
        if (profession == "Advocat")
        {
            criminal.crimeAdvokat = crime;
        }
        int[] arr = new int[5];
        arr[0] = a;
        arr[1] = b;
        arr[2] = c;
        arr[3] = d;
        arr[4] = e;
        Side side = this as Side;
        Arguments arguments = new Arguments(arr, criminal, side);
        return arguments;
    }
}