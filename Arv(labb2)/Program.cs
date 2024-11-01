namespace Arv_labb2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog("kalle", 5, 5.6m,"labrador");
            //Console.WriteLine(dog);
            //Console.WriteLine($"Hunden låter: {dog.MakeSound()}\n");

            //Lion lion = new Lion("leo", 7, 10.5m, "Darkbrown");
            //Console.WriteLine(lion);
            //Console.WriteLine($"Lion låter: {lion.MakeSound()}\n");

            //Cat cat = new Cat("scar", 3, 4.5m,"playful");
            //Console.WriteLine(cat);
            //Console.WriteLine($"Katten låter:{cat.MakeSound()}\n");

            //Chihuahua chihuahua = new Chihuahua("Boss", 5, 6.5m);
            //Console.WriteLine(chihuahua);

            //Bulldog bulldog = new Bulldog("Bull", 3, 3.5m);
            //Console.WriteLine(bulldog);



            

            // test för default-värden:

            //Dog default1 = new Dog();
            //Console.WriteLine($"Dog: Name: {default1.Name}, Age: {default1.Age}, Weight: {default1.Weight}, Specie: {default1.Specie}, Habitat: {default1.Habitat}, Breed: {default1.Breed}");
            //Console.WriteLine($"Hunden låter: {default1.MakeSound()}");

            //Lion default2 = new Lion();
            //Console.WriteLine($"\nLion: Name: {default2.Name}, Age: {default2.Age}, Weight: {default2.Weight}, Specie: {default2.Specie}, Habitat: {default2.Habitat}, Color: {default2.Color}");
            //Console.WriteLine($"Lion låter: {default2.MakeSound()}");

            //Cat default3 = new Cat();
            //Console.WriteLine($"\nCat: Name: {default3.Name}, Age: {default3.Age}, Weight: {default3.Weight}, Specie: {default3.Specie}, Habitat: {default3.Habitat}, Behavior: {default3.Behavior}");
            //Console.WriteLine($"Katten låter:{default3.MakeSound()}");

            //Chihuahua default4 = new Chihuahua();
            //Console.WriteLine($"\nChihuahua: Name: {default4.Name}, Age: {default4.Age}, Weight: {default4.Weight}, Specie: {default4.Specie}, Habitat: {default4.Habitat}, BArk energy: {default4.BarkEnergy}");

            //Bulldog default5 = new Bulldog();
            //Console.WriteLine($"\nBulldog: Name: {default5.Name}, Age: {default5.Age}, Weight: {default5.Weight}, Specie: {default5.Specie}, Habitat: {default5.Habitat}, Lazy: {default5.Lazy}");


            // frågar om man vill skapa ny djur:

            bool createAnimal = true; 
            while(createAnimal)
            {

                Console.WriteLine("\nVill du skapa ett nytt djur som inte finns här? ja/nej");
                string userInput = Console.ReadLine();
                if(userInput.ToLower() == "ja")
                {
                    Animal newAnimal = Animal.NewAnimal();
                    Console.WriteLine($"Det nya djuret {newAnimal.Name} som skapats låter: {newAnimal.MakeSound()}");
                }
                else
                {
                    createAnimal = false;
                }
                

            }

        }
    }
}
