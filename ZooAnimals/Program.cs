using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimals
{
    class Program
    {
        public static void Main(string[] arg)
        {
            brown_rat ratty = new brown_rat(1,11,1, "female", "grassland", "cake", 7, 700, "none", 20);
            Console.WriteLine("rat made");
            Console.WriteLine(ratty.gender);
            Console.WriteLine(ratty.ToString());


            Animal animal = new Animal(1, "female", "grassland", "cake", 7, 700, "none", 20);
            Console.WriteLine(animal.ToString());

            Console.WriteLine("Hello world james in da house");

        }


    }
}
