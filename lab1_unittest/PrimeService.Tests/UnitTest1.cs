namespace PrimeService.Tests;

public class Tests
{
    [OneTimeSetUp]
    public void init()
    {
        Console.WriteLine("一次性的啟動");
        TestContext.Progress.WriteLine("最初的啟動");
    }
    [OneTimeTearDown]
    public void finalize()
    {
        Console.WriteLine("一次性的清除");
        TestContext.Progress.WriteLine("最後的清除");
    }
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("準備環境");
    }
    [TearDown]
    public void StoreData()
    {
      Console.WriteLine("清除環境，儲存資料。");  
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine("This is Test1");
        Assert.Pass();
    }
    [Test]
    [Ignore("尚未完成的工作")]
    public void Test2()
    {
        Console.WriteLine("This is Test2");
        Assert.Fail("這是意料之中的錯誤");       
    }
}