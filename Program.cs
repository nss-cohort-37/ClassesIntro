using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFordBronco = new Car(40000, "Ford", "Bronco", 1982);

            Car mySubaru = new Car(10000)
            {
                Make = "Subaru",
                Model = "Forrester",
                Year = 1999,
            };

            myFordBronco.Drive(9999);

            Console.WriteLine($"Bronco needs service:  {myFordBronco.NeedsMaintenance}");

            myFordBronco.Drive(60);

            Console.WriteLine($"Bronco needs service:  {myFordBronco.NeedsMaintenance}");

            myFordBronco.Service(true);
        }
    }
}