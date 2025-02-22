using NUnit.Framework;

[TestFixture]  
public class ArrayUtilsTests
{
    [Test]  
    public void TestFindMax()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int result = ArrayUtils.FindMax(numbers);
        Assert.AreEqual(5, result);  
    }

    [Test]  
    public void TestFindMin()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int result = ArrayUtils.FindMin(numbers);
        Assert.AreEqual(1, result);  
    }
}
