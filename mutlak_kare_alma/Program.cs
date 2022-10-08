using System;

namespace mutlak_kare_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı dizisi giriniz: ");
            string numbers = Console.ReadLine();
            getAbsoluteSquare(numbers);
            Console.ReadKey();
        }

        static void getAbsoluteSquare(string numbers)
        {
            int diff = 0 , count = 0 , absq = 0 , absqcount= 0;
            string[] numberList = new string[numbers.Length];
            numberList = numbers.Split(' ');   

            for (int i = 0; i < numberList.Length; i++)
            {
                if (int.Parse(numberList[i]) < 67)
                {
                    diff = 67 - int.Parse(numberList[i]);
                    count += diff;
                }
                else if (int.Parse(numberList[i]) > 67)
                {
                    absq = (int)Math.Pow((int.Parse(numberList[i]) - 67),2);
                    absqcount += absq;  
                }
            }
            Console.WriteLine(count + " " + absqcount);
        }
    }
}
