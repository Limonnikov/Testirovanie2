using NUnit.Framework;

namespace TestProject1;

public class State_Tests
{
    [Test]
    public void Test3_1_1()
    {
        Human human = new Human("Gena", 44, true);
        Assert.IsTrue(human.isWorker);
    }
    [Test]
    public void Test3_1_2()
    {
        Human human = new Human("Gena", 44, false);
        Assert.IsTrue(!human.isWorker);
    }
    [Test]
    public void Test3_1_3()
    {
        Human human = new Human("Gena", 44, false);
        human.changeWorkStatus();
        Assert.IsTrue(human.isWorker);
    }
  
    
    [Test]
    public void Test3_2_1()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        Assert.IsFalse(gena.sbejal);
    }
    [Test]
    public void Test3_2_2()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(0, Crime.murder, human); 
        gena.TryAWayOut();
        Assert.IsFalse(gena.sbejal);
    }
    [Test]
    public void Test3_2_3()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        gena.TryAWayOut();
        Assert.IsTrue(gena.sbejal);
    }
    
    [Test]
    public void Test3_2_4()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        Assert.IsFalse(gena.getFree());
    }
    [Test]
    public void Test3_2_5()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        gena.TryAWayOut();
        Judge judge = new Judge(32, human);
        DB db = new DB();
        judge.getPrigivor(gena, db);
        Assert.IsTrue(gena.getFree());
    }
    [Test]
    public void Test3_2_6()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        Judge judge = new Judge(32, human);
        DB db = new DB();
        judge.getPrigivor(gena, db);
        Assert.IsTrue(gena.getFree());
    }
    
    [Test]
    public void Test3_2_7()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        Assert.IsFalse(gena.getVinoven());
    }
    [Test]
    public void Test3_2_8()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        Judge judge = new Judge(32, human);
        DB db = new DB();
        judge.getPrigivor(gena, db);
        Assert.IsFalse(gena.getVinoven());
    }
    [Test]
    public void Test3_2_9()
    {
        Human human = new Human("Anya", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        gena.TryAWayOut();
        Judge judge = new Judge(32, human);
        DB db = new DB();
        judge.getPrigivor(gena, db);
        Assert.IsTrue(gena.getVinoven());
    }
    [Test]
    public void Test3_2_10()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human); 
        gena.TryAWayOut();
        Judge judge = new Judge(32, human);
        DB db = new DB();
        judge.getPrigivor(gena, db);
        Assert.IsTrue(gena.getVinoven());
    }
    
    
    [Test]
    public void Test3_3_1()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human);
        Side advocat = new Side("Advocaat", 21, human);
        Arguments arg = advocat.GetArguments(gena, Crime.repost_on_VK, 1, 1, 1, 1, 3);
        Assert.IsTrue(arg.accepted);
    }
    
    
    [Test]
    public void Test3_4_1()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human);
        Judge judge = new Judge(32, human);
        DB db = new DB();
        var prigovor = judge.getPrigivor(gena, db);
        Assert.IsTrue(prigovor.isFree);
    }
    [Test]
    public void Test3_4_2()
    {
        Human human = new Human("Anya", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human);
        Judge judge = new Judge(32, human);
        DB db = new DB();
        var prigovor = judge.getPrigivor(gena, db);
        Assert.IsTrue(prigovor.isFree);
    }
    [Test]
    public void Test3_4_3()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human);
        Judge judge = new Judge(32, human);
        DB db = new DB();
        gena.TryAWayOut();
        var prigovor = judge.getPrigivor(gena, db);
        Assert.IsTrue(prigovor.isFree);
    }
    
    [Test]
    public void Test3_4_4()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human);
        Judge judge = new Judge(32, human);
        DB db = new DB();
        var prigovor = judge.getPrigivor(gena, db);
        Assert.IsFalse(prigovor.Vinoven);
    }
    [Test]
    public void Test3_4_5()
    {
        Human human = new Human("Anya", 44, true);
        Criminal gena = new Criminal(0, Crime.murder, human);
        Judge judge = new Judge(32, human);
        DB db = new DB();
        var prigovor = judge.getPrigivor(gena, db);
        Assert.IsTrue(prigovor.Vinoven);
    }
    [Test]
    public void Test3_4_6()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human);
        Judge judge = new Judge(32, human);
        DB db = new DB();
        gena.TryAWayOut();
        var prigovor = judge.getPrigivor(gena, db);
        Assert.IsTrue(prigovor.Vinoven);
    }
    
    
    [Test]
    public void Test3_4_7()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(100, Crime.murder, human);
        Judge judge = new Judge(32, human);
        DB db = new DB();
        gena.TryAWayOut();
        var prigovor = judge.getPrigivor(gena, db);
        Assert.IsFalse(prigovor.betterCrime);
    }
    [Test]
    public void Test3_4_8()
    {
        Human human = new Human("Gena", 44, true);
        Criminal gena = new Criminal(0, Crime.murder, human);
        Side adv = new Side("Advocat", 14, human);
        var advArguments = adv.GetArguments(gena, Crime.repost_on_VK, -10, -3, -2, -5, -2);
        Side pr = new Side("Procuror", 14, human);
        var prArguments = pr.GetArguments(gena, Crime.murder, 13, 4, 2, 7,1);
        Judge judge = new Judge(32, human);
        DB db = new DB();
        var prigovor = judge.getPrigivor(gena, db);
        Assert.IsTrue(prigovor.betterCrime);
    }
}