using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03._2023_dz
{
    interface Auto
    {
        string Frame();
        string Engine();
        string Wheels();
        string Transmission();
    }

    class DaewooLanos : Auto
    {
        public string Frame()
        {
            return "Седан";
        }
        public string Engine()
        {
            return "98 л.с.";
        }
        public string Transmission()
        {
            return "Manual - 5";
        }
        public string Wheels()
        {
            return "R 13";
        }
    }

    class FordProbe : Auto
    {
        public string Frame()
        {
            return "Купе";
        }
        public string Engine()
        {
            return "160 л.с.";
        }
        public string Transmission()
        {
            return "Auto - 4";
        }
        public string Wheels()
        {
            return "R 14";
        }
    }

    class VolzwagenPolo : Auto
    {
        public string Frame()
        {
            return "Универсал";
        }
        public string Engine()
        {
            return "110 л.с.";
        }
        public string Transmission()
        {
            return "Manual - 5";
        }
        public string Wheels()
        {
            return "R 15";
        }
    }

    class Car
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2);
            return "Product parts: " + str + "\n";
        }
    }

    class Director
    {
        private Auto auto;

        public Auto BuildAuto
        {
            set { auto = value; }
        }
        public void ShowElements()
        {
            Console.WriteLine($"Frame: {auto.Frame()}");
            Console.WriteLine($"Engine: {auto.Engine()}");
            Console.WriteLine($"Wheels: {auto.Wheels()}");
            Console.WriteLine($"Transmission: {auto.Transmission()}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var daewoo = new DaewooLanos();
            director.BuildAuto = daewoo;
            director.ShowElements();

            Console.WriteLine();

            var volks = new VolzwagenPolo();
            director.BuildAuto = volks;
            director.ShowElements();

        }
    }
}
