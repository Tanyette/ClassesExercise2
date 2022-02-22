using System;
using System.Collections.Generic;


namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Cars();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            var mazda = new Cars()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            var chevy = new Cars("Chevy", "Impala", 2001);

            var carList = new List<Cars>() { myCar,mazda,chevy, new Cars()};

            foreach(var vehicle in carList) 
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");

                //testing
            }



            
        }
    }
}
