using NUnit.Framework;

namespace TestProject1;

public class Features_Tests
{
    [Test]
    public void Test1_1_1()
    {
        Human human = new Human("Bobik", 45, true);
        Assert.IsTrue(human.getWorkStatus());
    }
}