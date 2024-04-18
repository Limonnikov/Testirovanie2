using NUnit.Framework;

namespace TestProject1;

public class Ways_Tests
{
    [Test]
    public void Test4_1_1()
    {
        JudgeProcess itog = new JudgeProcess(34, 12, 43, "Krisa", 100, Crime.murder, 
            Crime.injuries, -12, -3, -5, -1, -3,
            13, 4, 2, 7,1);
        Assert.That(itog.PrigovorSummury(), Is.EqualTo("Пподсудимый сбежал!"));
    }
    
    [Test]
    public void Test4_2_1()
    {
        JudgeProcess itog = new JudgeProcess(34, 12, 43, "Krisa", 0, Crime.murder, 
            Crime.injuries, -12, -3, -5, -1, -3,
            13, 4, 2, 7,1);
        Assert.That(itog.PrigovorSummury(), Is.EqualTo("Подсудимый полностью оправдан. Полный успех адвоката"));
    }
    
    [Test]
    public void Test4_3_1()
    {
        JudgeProcess itog = new JudgeProcess(34, 12, 43, "Krisa", 0, Crime.murder, 
            Crime.injuries, -10, -3, -2, -5, -2,
            13, 4, 2, 7,1);
        Assert.That(itog.PrigovorSummury(), Is.EqualTo("Подсудимый виновен, но приговор смягчен. Какой никакой, но успех адвоката"));
    }
    
    [Test]
    public void Test4_4_1()
    {
        JudgeProcess itog = new JudgeProcess(34, 12, 43, "Sanya", 1, Crime.murder, 
            Crime.injuries, -1, -1, -1, -1, -1,
            13, 4, 2, 7,1);
        Assert.That(itog.PrigovorSummury(), Is.EqualTo("Подсудимый наказан по всей строгости. Провал адвоката"));
    }
}