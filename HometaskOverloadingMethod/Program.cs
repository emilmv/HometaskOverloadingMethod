using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.Metadata;

namespace HometaskOverloadingMethod;

internal class Program
{
    static void Main(string[] args)
    {
        #region Task1

        //Console.WriteLine("Verilmish 3 ededden 10-100 araliginda yerleshenlerin cemini tapan algoritm");
        //Console.WriteLine("===========================================================================");
        //Console.WriteLine("Birinci ededi daxil edin:");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Ikinci ededi daxil edin:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Ucuncu ededi daxil edin:");
        //int c = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Cavab: "+sumOfThree(a,b,c));

        #endregion

        #region Task2

        //Console.WriteLine("Verilmish ay hansi fesile aiddir?");
        //Console.WriteLine("=================================");
        //Console.WriteLine("Ayin reqemini daxil edin:");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{a} ededi " + whichSeason(a));

        #endregion

        #region Task3

        //Console.WriteLine("Verilmish 3 reqemli ededin reqemleri hasili nechedir?");
        //Console.WriteLine("3 reqemli eded daxil edin:");
        //int a=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Cavab: "+multOfDigits(a));

        #endregion

        #region Task4

        //Console.WriteLine("Aksiya: 3 mehsul alana en ucuzu pulsuz");
        //Console.WriteLine("========================================");
        //Console.WriteLine("Birinci mehsulun deyerini daxil edin:");
        //double a = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ikinci mehsulun deyerini daxil edin:");
        //double b = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ucuncu mehsulun deyerini daxil edin");
        //double c = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Odeyeceyiniz mebleg: "+cheapestIsFree(a,b,c));
        
        #endregion

    }
    static int sumOfThree(int a, int b, int c)
    {
        int result = 0;
        
        for (int i = 0; i <= a; i++)
        {
            int temp = a;
            int digitCount = 0;
            while (temp > 0)
            {
                digitCount++;
                temp /= 10;
            }
            if (digitCount == 2)
            {
                result += a;
                break;
            }
        }
        for (int i = 0; i <= b; i++)
        {
            int temp = b;
            int digitCount = 0;
            while (temp > 0)
            {
                digitCount++;
                temp /= 10;
            }
            if(digitCount == 2)
            {
                result += b;
                break;
            }
        }
        for (int i = 0; i <= c; i++)
        {
            int temp = c;
            int digitCount = 0;
            while (temp > 0)
            {
                digitCount++;
                temp /= 10;
            }
            if(digitCount == 2)
            {
                result += c;
                break;
            }
        }
        return result;








    }

    static string whichSeason(int a)
    {
        if (a > 12)
            return "Duzgun reqem daxil edin";
        if (a >= 3 && a <= 5)
            return "Yaz fesline aiddir";
        if (a >= 6 && a <= 8)
            return "Yay fesline aiddir";
        if (a >= 9 && a <= 11)
            return "Payiz fesline aiddir";
        else return "Qish fesline aiddir";

    }

    static int multOfDigits(int a)
    {
        int firstDigit = a%10;
        int secondDigit = (a/10)%10;
        int thirdDigit = a/100;
       return firstDigit*secondDigit*thirdDigit;
    }

    static double cheapestIsFree(double a, double b, double c)
    {
        double result = 0;

        if (a > b)
        {
            if (a > c)
                result += a;
            else
                return a + c;
        }
        if (a < b)
        {
            if (a < c)
                return c + b;
            else
                return a + b;
        }
        if (b > c)
            result += b;
        else
            result += c;
        return result;
    }



}
