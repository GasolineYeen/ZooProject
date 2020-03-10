using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimals
{
    class brown_rat:Rodent
    {
        public brown_rat(int insisorSize, int youngCount, int chosenWeight, string chosenGender, string chosenHabitat, string chosenDiet, int chosenEyeSight, int chosenRange, string chosenMedication, int chosenComfortTemp)
: base(insisorSize, youngCount, chosenWeight, chosenGender, chosenHabitat, chosenDiet, chosenEyeSight, chosenRange, chosenMedication, chosenComfortTemp)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Brow Rat";
        }
    }
}
