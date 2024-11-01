namespace Arv_labb2_
{
    public class Animal
    {
        public string Name { get; set; } = "CR";      // det värdet den har om man inte ger värden under djuren 
        public int Age { get; set; } = 4;
        public decimal Weight { get; set; } = 7.6m;
        public string Specie { get; set; } = "okänt ras";  // art
        public string Habitat { get; set; } = "okänt miljö";         //miljö

        public string Eat()
        {
            return $"{Name} is eating";
        }
        public string Sleep()
        {
            return $"{Name} is sleeping";
        }

        public virtual string Move()
        {
            return $"{Name} is now moving ";
        }

        public Animal(string name, int age, decimal weight, string specie, string habitat)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Specie = specie;
            Habitat = habitat;
        }

        public virtual string MakeSound()
        {
            return "ljud från ett djur";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Specie: {Specie}, Habitat: {Habitat}";
        }

        public static Animal NewAnimal()  // constructor som man kan ska nya djur med som returnerar animal 
        {
            Console.WriteLine("Skapa ett nytt djur med dina egna värden:");
            Console.WriteLine("Vad vill du att den ska heta?");
            string name = Console.ReadLine();
            Console.WriteLine("Hur gammal ska den vara?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket ska den väga?");
            decimal weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("vilken art har den?");
            string specie = Console.ReadLine();
            Console.WriteLine("I vilken miljö ska den vara i?");
            string habitat = Console.ReadLine();
            return new Animal(name, age, weight, specie, habitat);
        }
    }
}
