using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Circus_Trein.Models
{
    public class Wagon
    {
        public List<Animal> Animals { get; set; }

        public Wagon(List<Animal> aAnimalsList) 
        {
            Animals = aAnimalsList;
        }
        int GetSpace() 
        {
            int space = 10 - GetUsedSpace();
            return space;
        }
        int GetUsedSpace()
        {
            int space = 0;
            foreach (Animal animal in Animals)
            {
                space += (int)animal.Size;
            }
            return space;
        }
    }
}
