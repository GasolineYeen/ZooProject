using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimals
{
    class Bird 
    {
        private int eggCount { get; set; }
        private string flightTechnique { get; set; }
        private int wingSpan { get; set; }

        public void Fly()
        {
            Console.WriteLine("Flew");
        }

    }
}
