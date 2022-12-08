using Prime.Service;
namespace Prime.Service.Tests;
[TestFixture]
public class PrimeTest1
{
    private PrimeService primeService = null!; //驚嘆號代表不要警告
    [OneTimeSetUp]
    public void Prepare()
    {
        primeService = new PrimeService();
    }
    [Test]
    public void test1()
    {
        int no = 255;
        bool result = primeService.IsPrime(no);
        Assert.IsFalse(result,$"{no} shoud not be a prime");
    }
    [Test]
    public void test2()
    {
        bool result = primeService.IsPrime(2);
        Assert.IsTrue(result,"2 shoud be a prime");
    }
}