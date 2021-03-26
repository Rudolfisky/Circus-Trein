using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Circus_Trein.Models
{
    public class Animal
    {
        public Type Type { get; set; }
        public Size Size { get; set; }
        public Animal(Type aType, Size aSize) 
        {
            Type = aType;
            Size = aSize;
        }
    }
}
