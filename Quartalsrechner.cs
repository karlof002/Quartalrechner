using System;

namespace Quartalsrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            int quarter;

            Console.Write("Geben sie bitte ihr Geburtsmonat in Form einer Zahl ein: ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month >= 1 &&  month <= 12)
            {
                if(month <= 3)
                {
                    quarter = 1;
                }
                else if(month <= 6)
                {
                    quarter = 2;
                }
                else if(month <= 9)
                {
                    quarter = 3;
                }
                else
                {
                    quarter = 4;
                }

                Console.WriteLine("Sie wurden im {0}. Quartal geboren.", quarter);
            }
            else
            {
                Console.WriteLine("Sie haben eine keine Zahl zwischen 1 und 12 eingegeben.");
            }
        }
    }
}
