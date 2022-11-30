using System;

namespace TempService
{
    internal class Program
    {
        static void Main()
        {
            /*temperature ob1 = new temperature();
            temperature ob2 = new temperature();
            Console.WriteLine(ob1.FTC(101));
            Console.WriteLine(ob2.CTF(100));*/
        }
    }

    class temperature
    {
        public double CTF(double temp)
        {
            double fretemp = 0.00;
            fretemp = ((temp * 9 / 5) + 32);

            return (fretemp);
        }

        public double FTC(double temp)
        {
            double celtemp = 0.00;
            celtemp = ((temp - 32) * 5 / 9);

            return (celtemp);
        }
    }
}