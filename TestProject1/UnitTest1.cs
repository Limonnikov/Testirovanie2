using NUnit.Framework;

namespace TestProject1;

public class Features_Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Human human = new Human("Bobik", 45, true);
        Assert.IsTrue(human.getWorkStatus());
    }
}