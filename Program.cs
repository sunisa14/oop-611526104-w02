using oop_6115261014_w02;
using System;

namespace oop_6115261014_w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r434 = new Room("434", "434", 4, 4, "math");
            Console.WriteLine(r434);
            Building b7 = new Building("7 ", " loly ", " 7.233 ", " 232.222 ");
            Console.WriteLine(b7);
            Subject mt = new Subject("0001 ", " math ", " 2 ", " 2 ", " 2 ");
            Console.WriteLine(mt);
            Lecturer th = new Lecturer("Sunisa ", " lumsiri ", " Teacher ");
            Console.WriteLine(th);
            Section tp = new Section("122 ", " 02 ", " math ", " Teachersunisa ", " 10 apil ", " 08.00 ", " 10.00 ");
            Console.WriteLine(tp);
            Programm co = new Programm("Com ", " Bachelor degree ");
            Console.WriteLine(co);
        }

    }
}
