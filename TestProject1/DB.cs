using System;
using System.Net.NetworkInformation;

namespace TestProject1;

public class DB
{
    public Criminal[] criminals = new Criminal[5];

    public DB()
    {
        addCriminal();
    }

    public void addCriminal()
    {
        Human Sanya = new Human("Sanya", 22, true);
        Human Petya = new Human("Petya", 28, true);
        Human Anya = new Human("Anya", 21, true);
        Human Ilya = new Human("Ilya", 100, true);
        Human Masha = new Human("Anya", 18, true);
        criminals[0] = new Criminal(100, Crime.set_fire,Sanya);
        criminals[1] = new Criminal(1, Crime.murder,Petya);
        criminals[2] = new Criminal(30, Crime.abuse_of_official_position,Anya);
        criminals[3] = new Criminal(47, Crime.repost_on_VK,Ilya);
        criminals[4] = new Criminal(79, Crime.theft,Masha);
        
    }

    public void addNewCriminal(Criminal criminal)
    {
        Array.Resize(ref criminals, criminals.Length + 1);
        criminals[criminals.Length - 1] = criminal;
    }

    public int returnCountCrime(Criminal criminal)
    {
        int a = 0;
        for (int i = 0; i < criminals.Length; ++i)
        {
            if (criminal.name == criminals[i].name) a++;
        }
        return a;
    }
}