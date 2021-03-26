using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Circus_Trein.Models
{
    public class Train
    {
        public List<Wagon> Wagons { get; }
        public List<Animal> Animals { get; }
        public Train(int[] aAnimals) 
        {
            Animals = new List<Animal>();
            MakeAnimals(aAnimals);
            SortAnimals();
            Console.WriteLine(aAnimals);

        }
        void SortAnimals() 
        {

            Console.WriteLine(Animals);
            List<int> somethings = new List<int>();
            foreach (Animal animal in Animals)
            {
                List<Animal> wagonAnimals = new List<Animal>();

                if (animal.Type == Type.Carnivore && animal.Size == Size.Large)
                {

                    wagonAnimals.Add(animal);

                    Console.WriteLine(animal);
                    somethings.Add((int)animal.Size);
                }
                //AddWagon(wagonAnimals);

                Console.WriteLine(animal.Type);
                Console.WriteLine(animal.Size);
            }
            Console.WriteLine(somethings);
            Console.WriteLine(Wagons);
        }
        void MakeAnimals(int[] aAnimals)
        {
            for (int i = 0; i < aAnimals[0];)
            {
                AddAnimal(Type.Carnivore, Size.Small);
                i++;
            }
            for (int i = 0; i < aAnimals[1];)
            {
                AddAnimal(Type.Carnivore, Size.Medium);
                i++;
            }
            for (int i = 0; i < aAnimals[2];)
            {
                AddAnimal(Type.Carnivore, Size.Large);
                i++;
            }
            for (int i = 0; i < aAnimals[3];)
            {
                AddAnimal(Type.Herbivore, Size.Small);
                i++;
            }
            for (int i = 0; i < aAnimals[4];)
            {
                AddAnimal(Type.Herbivore, Size.Medium);
                i++;
            }
            for (int i = 0; i < aAnimals[5];)
            {
                AddAnimal(Type.Herbivore, Size.Large);
                i++;
            }
        }
        void AddAnimal(Type aType, Size aSize) 
        {
            Animal aAnimal = new Animal(aType, aSize);
            Animals.Add(aAnimal);
        }
        void AddWagon(List<Animal> aAnimals)
        {
            Wagon aWagon = new Wagon(aAnimals);
            Wagons.Add(aWagon);
        }

    }
}
