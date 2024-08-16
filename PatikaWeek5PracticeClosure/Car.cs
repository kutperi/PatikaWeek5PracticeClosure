using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek5PracticeClosure
{
    // Araba -> Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı
    public class Car
    {
        DateTime _productionDate;
        int _serialNumber;
        string _brand;        
        string _model;        
        string _colour;        
        int _gateCount;

        public DateTime ProductionDate { get; set; }

        public int SerialNumber { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public int GateCount 
        {
            get
            {
                return _gateCount;
            }
            set
            {
                if (value == 4 || value == 2)
                {
                    _gateCount = value;
                }
                else
                {
                    throw new GateCountException();
                }
            } 
        }

        public Car()
        {
            ProductionDate = DateTime.Now;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Seri Numarası: {SerialNumber}, Markası: {Brand}");
        }
    }
}
