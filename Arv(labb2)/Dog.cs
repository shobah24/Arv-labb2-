namespace Arv_labb2_
{
    public class Dog : Animal
    {
        public string Breed { get; set; } = "okänt";  // ny egenskap för hunden där man ger vilken ras det är

        public Dog(string name = "Dolle", int age = 5, decimal weight = 15.0m, string breed = "mixed") : base(name, age, weight, "Dog", "City")
        {
            Breed = breed;
        }
        public string Swim()
        {
            return $"{Name} is swimming.";
        }
        public override string MakeSound()
        {
            return "Woof! Woof! Woof!";
        }

        public override string ToString()
        {
            return base.ToString() + $", Breed: {Breed}";
        }
    }
}
