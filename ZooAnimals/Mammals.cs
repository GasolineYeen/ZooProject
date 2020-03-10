using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimals
{
    class Mammals: Animal
    {
        public Mammals(int youngCount, int chosenWeight, string chosenGender, string chosenHabitat, string chosenDiet, int chosenEyeSight, int chosenRange, string chosenMedication, int chosenComfortTemp)
        :base(chosenWeight, chosenGender, chosenHabitat, chosenDiet, chosenEyeSight, chosenRange, chosenMedication, chosenComfortTemp)
        {
            this.youngCount = youngCount;
        }
        private int youngCount { get; set; }
        public void ProduceMilk()
        {

        }
    }
}
