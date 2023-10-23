using System;

namespace Animal
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string animalType, string[] animalInfo)
        {
            string name = animalInfo[0];
            double weight = double.Parse(animalInfo[1]);

            switch (animalType)
            {
                case "Mouse":
                    string livingRegion = animalInfo[2];
                    return new Mouse(name, weight, livingRegion);
                case "Zebra":
                    livingRegion = animalInfo[2];
                    return new Zebra(name, weight, livingRegion);
                case "Tiger":
                    livingRegion = animalInfo[2];
                    return new Tiger(name, weight, livingRegion);
                case "Cat":
                    livingRegion = animalInfo[2];
                    string breed = animalInfo[3];
                    return new Cat(name, weight, livingRegion, breed);
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
