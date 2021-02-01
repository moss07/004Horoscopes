using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004Horoscopes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a value between 1-12 :  ");
            int number = int.Parse(Console.ReadLine());

            Horoscopes horoscope;
            horoscope = (Horoscopes)number;

            Console.WriteLine("Your horoscope is :  " + horoscope);
        }

        enum Horoscopes
        {
            Capricorn = 1,
            Aquarius,
            Pisces,
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius
        }
    }
}
