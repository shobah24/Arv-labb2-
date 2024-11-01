namespace Arv_labb2_
{
    public class Cat : Animal
    {
        public string Behavior { get; set; } = "Playful";

        public Cat(string name = "simba", int age = 2, decimal weight = 5.6m, string behavior = "playful") : base(name, age, weight, "Cat", "House")
        {
            Behavior = behavior;

        }

        public string Scrath()
        {
            return $"{Name} is scratching the couch.";
        }

        public override string MakeSound()
        {
            return "Meow! Meow! ";
        }

        public override string ToString()
        {
            return base.ToString() + $", Behavior: {Behavior}";
        }

    }
}
