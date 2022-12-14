using System;

namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {// Verilmiş ədədin verilmiş qüvvətini tapan metod
            Console.WriteLine("edeleri daxil edin:");
            var input0=Console.ReadLine();
            int num=Convert.ToInt32(input0);
            var input1=Console.ReadLine();
            int power = Convert.ToInt32(input1);
            int result=Pow(num, power);
            Console.WriteLine(result);

            //Verilmiş 3 ədəddən ən böyüyünü tapan metod
            Console.WriteLine("Ededleri daxil edin");
            var input2 = Console.ReadLine();
            int num1 = Convert.ToInt32(input2);
            var input3 = Console.ReadLine();
            int num2 = Convert.ToInt32(input3);
            var input4 = Console.ReadLine();
            int num3 = Convert.ToInt32(input4);
            var max = 0;
            Console.WriteLine(BiggestInteger(num1, num2, num3));

            //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod
            byte[] numbers = new byte[num];

        }
        static int Pow(int num,int power)
        {
            int result = 1;
            for (int i=0; i<power; i++) 
            {
                 result *= num;
                

            }
            return result;
        }
        static int BiggestInteger(int num1, int num2, int num3) 
        { 
            if (num1 > num2 && num1>num3) 
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            { 
                return num2;
            }else 
            { 
                return num3; 
            }



        }
        static int Sum(int num)
        {
            var sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum +=numbers[i];
            }
        }


    }
}
