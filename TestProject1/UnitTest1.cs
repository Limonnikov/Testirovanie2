using NUnit.Framework;

namespace TestProject1;

public class Features_Tests
{
    [Test]
    public void Test1_1_1()
    {
        Human human = new Human("Bobik", 45, true);
        Assert.That(human.name, Is.EqualTo("Bobik"));
    }
    [Test]
    public void Test1_1_2()
    {
        Human human = new Human("Bobik", 45, true);
        Assert.That(human.age, Is.EqualTo(45));
    }
    [Test]
    public void Test1_1_3()
    {
        Human human = new Human("Bobik", 45, true);
        Assert.IsTrue(human.isWorker);
    }
    
    
    [Test]
    public void Test1_2_1()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.That(criminal.scoreProc, Is.EqualTo(0));
    }
    [Test]
    public void Test1_2_2()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.That(criminal.scoreAdv, Is.EqualTo(0));
    }
    [Test]
    public void Test1_2_3()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.That(criminal.countCrime, Is.EqualTo(0));
    }
    [Test]
    public void Test1_2_4()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.IsFalse(criminal.sbejal);
    }
    [Test]
    public void Test1_2_5()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.That(criminal.crime, Is.EqualTo(Crime.murder));
    }
    [Test]
    public void Test1_2_6()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.That(criminal.crimeAdvokat, Is.EqualTo(Crime.innocent));
    }
    [Test]
    public void Test1_2_7()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.That(criminal.Luck, Is.EqualTo(24));
    }
    [Test]
    public void Test1_2_8()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.IsFalse(criminal.getFree());
    }
    [Test]
    public void Test1_2_9()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal criminal = new Criminal(24, Crime.murder, human);
        Assert.IsFalse(criminal.getVinoven());
    }
    
    
    [Test]
    public void Test1_3_1()
    {
        Human human = new Human("Bobik", 45, true);
        Side side = new Side("Advocat", 12, human);
        Assert.That(side.profession, Is.EqualTo("Advocat"));
    }
    [Test]
    public void Test1_3_2()
    {
        Human human = new Human("Bobik", 45, true);
        Side side = new Side("Advocat", 12, human);
        Assert.That(side.stage, Is.EqualTo(12));
    }
    
    
    [Test]
    public void Test1_4_1()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        Side side = new Side("Advocat", 12, human);
        Arguments ar = side.GetArguments(crim, Crime.injuries, 1, 2, 3, 4, 5);
        Assert.That(ar.severity, Is.EqualTo(1));
    }
    [Test]
    public void Test1_4_2()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        Side side = new Side("Advocat", 12, human);
        Arguments ar = side.GetArguments(crim, Crime.injuries, 1, 2, 3, 4, 5);
        Assert.That(ar.aggravating, Is.EqualTo(2));
    }
    [Test]
    public void Test1_4_3()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        Side side = new Side("Advocat", 12, human);
        Arguments ar = side.GetArguments(crim, Crime.injuries, 1, 2, 3, 4, 5);
        Assert.That(ar.victims, Is.EqualTo(3));
    }
    [Test]
    public void Test1_4_4()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        Side side = new Side("Advocat", 12, human);
        Arguments ar = side.GetArguments(crim, Crime.injuries, 1, 2, 3, 4, 5);
        Assert.That(ar.badIntentions, Is.EqualTo(4));
    }
    [Test]
    public void Test1_4_5()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        Side side = new Side("Advocat", 12, human);
        Arguments ar = side.GetArguments(crim, Crime.injuries, 1, 2, 3, 4, 5);
        Assert.That(ar.safeFamily, Is.EqualTo(5));
    }
    [Test]
    public void Test1_4_6()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        Side side = new Side("Advocat", 12, human);
        Arguments ar = side.GetArguments(crim, Crime.injuries, 1, 2, 3, 4, 5);
        Assert.IsTrue(ar.accepted);
    }
    
    
    [Test]
    public void Test1_5_1()
    {
        Human human = new Human("Bobik", 45, true);
        Judge judge = new Judge(13, human);
        Assert.That(judge.stage, Is.EqualTo(13));
    }
    
    
    
    [Test]
    public void Test1_6_1()
    {
        DB db = new DB();
        Assert.That(db.criminals.Length, Is.EqualTo(5));
    }
    
    
    [Test]
    public void Test1_7_1()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        DB db = new DB();
        Judge judge = new Judge(12, human);
        Prigovor prigovor = judge.getPrigivor(crim, db);
        Assert.That(prigovor.name, Is.EqualTo("Bobik"));
    }
    [Test]
    public void Test1_7_2()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        DB db = new DB();
        Judge judge = new Judge(12, human);
        Prigovor prigovor = judge.getPrigivor(crim, db);
        Assert.That(prigovor.crime, Is.EqualTo(Crime.innocent));
    }
    [Test]
    public void Test1_7_3()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        DB db = new DB();
        Judge judge = new Judge(12, human);
        Prigovor prigovor = judge.getPrigivor(crim, db);
        Assert.IsTrue(prigovor.isFree);
    }
    [Test]
    public void Test1_7_4()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        DB db = new DB();
        Judge judge = new Judge(12, human);
        Prigovor prigovor = judge.getPrigivor(crim, db);
        Assert.IsFalse(prigovor.Vinoven);
    }
    [Test]
    public void Test1_7_5()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        DB db = new DB();
        Judge judge = new Judge(12, human);
        Prigovor prigovor = judge.getPrigivor(crim, db);
        Assert.IsFalse(prigovor.betterCrime);
    }
    [Test]
    public void Test1_7_6()
    {
        Human human = new Human("Bobik", 45, true);
        Criminal crim = new Criminal(23, Crime.murder, human);
        DB db = new DB();
        Judge judge = new Judge(12, human);
        Prigovor prigovor = judge.getPrigivor(crim, db);
        Assert.That(prigovor.skolkoSidet, Is.EqualTo(0));
    }
}