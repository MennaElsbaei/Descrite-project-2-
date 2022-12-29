using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace perfect_number__project_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the start : ");
            int start = int.Parse(Console.ReadLine());


            Console.WriteLine("Please enter the end : ");
            int end = int.Parse(Console.ReadLine());



            for (int i = start; i <= end; i++)
            {
                int sum = 0;

                for (int j = 1; j < i; j++)
                {


                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}