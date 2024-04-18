using NUnit.Framework;

namespace TestProject1;

public class Methods_Tests
{
    [Test]
    public void Test2_1_1()
    {
        JudgeProcess itog = new JudgeProcess(34, 12, 43, "Krisa", 100, Crime.murder, 
            Crime.injuries, -12, -3, -5, -1, -3,
            13, 4, 2, 7,1);
        Assert.That(itog.PrigovorSummury(), Is.EqualTo("Подсудимый сбежал!"));
    }
    
    
}