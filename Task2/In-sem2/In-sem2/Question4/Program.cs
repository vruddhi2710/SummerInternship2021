using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    /*
     Here, we are violating following principles of SOLID:
    Open Closed Principle:
        Here, we didn't consider what would happen if a
        specific type of animal is to be introduced like reptile or mammal
    Interface Segregation Principle:
        Here, the interfaces weren't segregated properly before which we fix in our code
    */
    class Program
    {
        static void Main(string[] args)
        {
            Fish f = new Fish();
            f.Breathe();
            f.Swim();
            Console.ReadLine();
        }
    }

    abstract class IAnimal
    {
        public virtual void Breathe() {/* breathe */}
    }

    abstract class ILandAnimal : IAnimal
    {
        public virtual void Walk() { /* walk */}
    }

    abstract class IWaterAnimal : IAnimal
    {
        public virtual void Swim() { /* swim */}
    }

    class Fish : IWaterAnimal
    {
    }
    class Bull : ILandAnimal
    {
    }
}
