using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double salesVolume = double.Parse(Console.ReadLine());
            double commission = -1.0;

            if (city == "sofia")
            {
                if (salesVolume >= 0 && salesVolume <= 500) commission = 0.05;
                else if (salesVolume > 500 && salesVolume <= 1000) commission = 0.07;
                else if (salesVolume > 1000 && salesVolume <= 10000) commission = 0.08;
                else if (salesVolume > 10000) commission = 0.12;
            }
            else if (city == "varna")
            {
                if (salesVolume >= 0 && salesVolume <= 500) commission = 0.045;
                else if (salesVolume > 500 && salesVolume <= 1000) commission = 0.075;
                else if (salesVolume > 1000 && salesVolume <= 10000) commission = 0.10;
                else if (salesVolume > 10000) commission = 0.13;

            }
            else if (city == "plovdiv")
            {
                if (salesVolume >= 0 && salesVolume <= 500) commission = 0.055;
                else if (salesVolume > 500 && salesVolume <= 1000) commission = 0.08;
                else if (salesVolume > 1000 && salesVolume <= 10000) commission = 0.12;
                else if (salesVolume > 10000) commission = 0.145;
            }

            if (commission < 0)
            {
                Console.WriteLine("error");
            } 

            else if (commission >= 0)
            {
                double totalincome = commission * salesVolume;
                Console.WriteLine("{0:f2}", totalincome);
            }

        }
    }
}
