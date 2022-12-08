using System;
namespace Prime.Service;
public class PrimeService
{
    public bool IsPrime(int candidate)
    {
        if(candidate <= 1)
        {
            return false;
        }
        for(int i = 1;i < candidate/2;i++)
        {
            if(candidate%i == 0 && i !=1)
            {
                return false;
            }
        }
        return true;
        //throw new NotImplementedException(" Not yet implemented.");
    }
}
