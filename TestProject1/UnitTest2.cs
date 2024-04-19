using NUnit.Framework;

namespace TestProject1;

public class Methods_Tests
{
    [Test]
    public void Test2_1_1()
    {
        Human human = new Human("Galya", 67, true);
        human.changeWorkStatus();
        Assert.IsFalse(human.getWorkStatus());
    }
    
    
    [Test]
    public void Test2_2_1()
    {
        Human human = new Human("Galya", 67, true);
        Criminal criminal = new Criminal(0, Crime.injuries, human);
        criminal.TryAWayOut();
        Assert.IsFalse(criminal.sbejal);
    }
    [Test]
    public void Test2_2_2()
    {
        Human human = new Human("Galya", 67, true);
        Criminal criminal = new Criminal(100, Crime.injuries, human);
        criminal.TryAWayOut();
        Assert.IsTrue(criminal.sbejal);
    }
    
    [Test]
    public void Test2_3_1()
    {
        Human human = new Human("Galya", 67, true);
        Side adv = new Side("Advocet", 12, human);
        Assert.That(adv.stage, Is.EqualTo(12));
    }
    [Test]
    public void Test2_3_2()
    {
        Human human = new Human("Galya", 34, true);
        Side adv = new Side("Advocet", 36, human);
        Assert.That(adv.stage, Is.EqualTo(12));
    }
    
    [Test]
    public void Test2_3_3()
    {
        Human human = new Human("Galya", 34, true);
        Criminal criminal = new Criminal(12, Crime.murder, human);
        Side adv = new Side("Advocat", 12, human);
        var arg = adv.GetArguments(criminal, Crime.robbery, 1, 2,3 ,4, 5 );
        Assert.That(criminal.crimeAdvokat, Is.EqualTo(Crime.robbery));
    }
    
    
    [Test]
    public void Test2_4_1()
    {
        Human human = new Human("Galya", 34, true);
        Criminal criminal = new Criminal(12, Crime.murder, human);
        Side adv = new Side("Advocat", 12, human);
        var arg = adv.GetArguments(criminal, Crime.robbery, 1, 2,3 ,4, 5 );
        int check = arg.GetFinallyMark();
        Assert.That(check, Is.EqualTo(1*3 + 2*2 + 3*4 + 4*1 + 5/2));
    }
    [Test]
    public void Test2_4_2()
    {
        Human human = new Human("Galya", 34, true);
        Criminal criminal = new Criminal(12, Crime.murder, human);
        Side adv = new Side("Advocat", 12, human);
        var arg = adv.GetArguments(criminal, Crime.robbery, 1, 2,3 ,4, 5 );
        Assert.That(criminal.scoreAdv, Is.EqualTo(1*3 + 2*2 + 3*4 + 4*1 + 5/2));
    }
    [Test]
    public void Test2_4_3()
    {
        Human human = new Human("Galya", 34, true);
        Criminal criminal = new Criminal(12, Crime.murder, human);
        Side adv = new Side("Procuror", 12, human);
        var arg = adv.GetArguments(criminal, Crime.robbery, 1, 2,3 ,4, 5 );
        Assert.That(criminal.scoreProc, Is.EqualTo(1*3 + 2*2 + 3*4 + 4*1 + 5/2));
    }
    
    
    [Test]
    public void Test2_5_1()
    {
        Human human = new Human("Galya", 34, true);
        Criminal criminal = new Criminal(12, Crime.murder, human);
        Judge judge = new Judge(12, human);
        DB db = new DB();
        judge.searchDB(criminal, db);
        Assert.That(criminal.countCrime, Is.EqualTo(0));
    }
    [Test]
    public void Test2_5_2()
    {
        Human human = new Human("Anya", 34, true);
        Criminal criminal = new Criminal(12, Crime.murder, human);
        Judge judge = new Judge(12, human);
        DB db = new DB();
        judge.searchDB(criminal, db);
        Assert.That(criminal.countCrime, Is.EqualTo(2));
    }
    
    [Test]
    public void Test2_5_3()
    {
        Human human = new Human("Anya", 34, true);
        Criminal criminal = new Criminal(12, Crime.murder, human);
        Judge judge = new Judge(12, human);
        DB db = new DB();
        var prigovor = judge.getPrigivor(criminal, db);
        Assert.That(prigovor.name, Is.EqualTo("Anya"));
    }
    
    [Test]
    public void Test2_5_4()
    {
        Human human = new Human("Anya", 34, true);
        Judge judge = new Judge(12, human);
        Assert.That(judge.stage, Is.EqualTo(12));
    }
    [Test]
    public void Test2_5_5()
    {
        Human human = new Human("Anya", 34, true);
        Judge judge = new Judge(100, human);
        Assert.That(judge.stage, Is.EqualTo(12));
    }
    
    
    [Test]
    public void Test2_6_1()
    {
        Human Sanya = new Human("Sanya", 22, true);
        //var sashka = new Criminal(100, Crime.set_fire,Sanya);
        DB db = new DB();
        Assert.That(db.criminals[0].name, Is.EqualTo("Sanya"));
    }
    
    [Test]
    public void Test2_6_2()
    {
        Human human = new Human("Serega", 24, true);
        var Sereja = new Criminal(100, Crime.set_fire, human);
        DB db = new DB();
        db.addNewCriminal(Sereja);
        Assert.That(db.criminals[5], Is.EqualTo(Sereja));
    }
    
    [Test]
    public void Test2_6_3()
    {
        Human human = new Human("Anya", 24, true);
        var Anya = new Criminal(100, Crime.set_fire, human);
        DB db = new DB();
        var count = db.returnCountCrime(Anya);
        Assert.That(count, Is.EqualTo(2));
    }
    
    
    [Test]
    public void Test2_7_1()
    {
        Human human = new Human("Anya", 24, true);
        var Anya = new Criminal(100, Crime.set_fire, human);
        Anya.TryAWayOut();
        DB db = new DB();
        Judge judge = new Judge(13, human);
        Prigovor prigovor = judge.getPrigivor(Anya, db);
        Assert.IsTrue(prigovor.isFree && prigovor.Vinoven);
    }
    [Test]
    public void Test2_7_2()
    {
        Human human = new Human("Gena", 24, true);
        var Anya = new Criminal(100, Crime.set_fire, human);
        DB db = new DB();
        Judge judge = new Judge(13, human);
        Prigovor prigovor = judge.getPrigivor(Anya, db);
        Assert.That(prigovor.skolkoSidet, Is.EqualTo(0));
    }
    [Test]
    public void Test2_7_3()
    {
        Human human = new Human("Anya", 24, true);
        var Anya = new Criminal(0, Crime.set_fire, human);
        DB db = new DB();
        Judge judge = new Judge(13, human);
        Prigovor prigovor = judge.getPrigivor(Anya, db);
        Assert.IsTrue(prigovor.Vinoven);
        Assert.IsFalse(prigovor.isFree);
    }
    
}