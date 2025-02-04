using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;
        public double age;
        public double weight;

        // constructor
        public Animal()
        {
            name = "";
            age = 0;
            weight = 0;

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
            Console.WriteLine();
        }

    }

    // derived class of Animal 
    class Cat : Animal
    {
        public string hobby;
     
        public Cat()
                : base() 
        {
            age = 0;
            weight = 0;
            hobby = "";
            
        }

        public Cat(string name, double age, double weight, string hobby)
            : base(name)
        {
            this.age = age;
            this.weight = weight;
            this.hobby = hobby;
        }

        public override void display()
        {
            Console.WriteLine("Cat information...");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Hobby: {hobby}");
        }
     }
    class Bear : Animal
    {
        public string hobby;

        public Bear()
                : base()
        {
            age = 0;
            weight = 0;
            hobby = "";

        }

        public Bear(string name, double age, double weight, string hobby)
            : base(name)
        {
            this.age = age;
            this.weight = weight;
            this.hobby = hobby;
        }

        public override void display()
        {
            Console.WriteLine("Bear information...");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Hobby: {hobby}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Cat cat1 = new Cat();
            cat1.name = "Biscuits";
            cat1.age = 3;
            cat1.weight = 7;
            cat1.hobby = "Sleeping";
            cat1.display();
            Console.WriteLine();

            Bear bear1 = new Bear();
            bear1.name = "Polar";
            bear1.age = 1;
            bear1.weight = 170;
            bear1.hobby = "Eating Fish";
            bear1.display();
            Console.WriteLine();

            //derived class object using parameterized constructor
            Cat cat2 = new Cat("Randall", 2, 5, "Purring");
            cat2.display();
            Console.WriteLine();

            Bear bear2 = new Bear("Greg", 4, 230, "Growling");
            bear2.display();


        }


    }
}
