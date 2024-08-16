using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek5PracticeClosure
{
    public class GateCountException : Exception
    {
        public GateCountException()
        {
            Console.WriteLine("Kapı sayısı 2 veya 4 olabilir lütfen tekrar deneyiniz.");
        }
    }
}
