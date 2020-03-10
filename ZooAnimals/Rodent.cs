using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimals
{
    class Rodent: Mammals
    {
        public Rodent(int insisorSize, int youngCount, int chosenWeight, string chosenGender, string chosenHabitat, string chosenDiet, int chosenEyeSight, int chosenRange, string chosenMedication, int chosenComfortTemp)
: base(youngCount, chosenWeight, chosenGender, chosenHabitat, chosenDiet, chosenEyeSight, chosenRange, chosenMedication, chosenComfortTemp)
        {
            this.insisorSize = 3;
        }
        public int insisorSize { get; set; }
    
    }
}
