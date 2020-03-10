using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimals
{
    class Animal
    {
        public double weight { get; set; }
        public string gender { get; }
        public string habitat { get; }
        public string diet { get; }
        public int eyeSight { get; set;  }
        public int range { get; set; }
        public string medication { get; set; }
        public int comfortTemp { get; }

        public Animal(double chosenWeight, string chosenGender, string chosenHabitat, string chosenDiet, int chosenEyeSight, int chosenRange, string chosenMedication, int chosenComfortTemp)
        {
            weight = chosenWeight;
            gender = chosenGender;
            habitat = chosenHabitat;
            diet = chosenDiet;
            eyeSight = chosenEyeSight;
            range = chosenRange;
            medication = chosenMedication;
            comfortTemp = chosenComfortTemp;
        }
        
        public void Movement(string direction)
        {

        }

        public void Consume(string direction)
        {

        }

        public override string ToString()
        {
            return $"Weight: {weight} Gender: {gender} Diet: {diet} Habitat: {habitat}";
        }
    }
}
