using System;

namespace Task2Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gonderilmis ededin reqemlerinin cemini qaytaran metod
            //-misalcun bu metodu call ederken arqument olaraq 451 gondersek
            //metoddan geriye 10 qayitmalidir


                int number;
            bool check;

            Console.WriteLine("Eded daxil edin : ");
            while (true)
            {
                check = int.TryParse(Console.ReadLine(), out number);
                if (check && number >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Warning!!! Xahiw edirik duzgun daxil edin :");
                }

            }

            Console.WriteLine($"{number} ededinin reqemlerinin cemi - {SumOfNumber(number)} edir");
        }

        static int SumOfNumber(int number)
        {
            int sum = 0;
            int temp;
            while (number != 0)
            {
                temp = number % 10;
                number /= 10;
                sum += temp;
            }

            return sum;
        }
    }
}
