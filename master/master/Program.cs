using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 10;

        try
        {
            b /= a;
        }
        catch (NullReferenceException e) when (a == 0)
        {
            Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }

}