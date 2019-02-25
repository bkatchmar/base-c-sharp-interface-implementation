using System;

namespace base_c_sharp_interface_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(age:5,name:"Rufus");
            Bird bird = new Bird(age:7,name:"Petey");
            Cat cat = new Cat(age:3,name:"Floyd");

            SoundOffThePet(dog);
            SoundOffThePet(bird);
            SoundOffThePet(cat);
        }

        private static void SoundOffThePet(IPet pet) {
            pet.SoundOff();
        }
    }
}