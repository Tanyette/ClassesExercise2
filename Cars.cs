using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
    public class Cars
    {

        public Cars() 
        {

        }
        public Cars(string make, string model, int year) 
        {
            Make = make;
            Model = model;
            Year = year;
        }

        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
