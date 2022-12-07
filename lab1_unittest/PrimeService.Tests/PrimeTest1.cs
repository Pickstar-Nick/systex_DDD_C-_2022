using Prime.Service;
namespace Prime.Service.Tests;
[TestFixture]
public class PrimeTest1
{
    [Test]
    public void test1()
    {
        Console.WriteLine("開始測試 PrimeService");
        try
        {
            PrimeService primeService = new PrimeService();
            bool result = primeService.IsPrime(1);
            Assert.IsFalse(result,"1 shoud not be a prime");
        }catch(Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }
}