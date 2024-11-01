namespace Arv_labb2_
{
    public class Lion : Animal
    {
        public string Color { get; set; } = "Golden";

        public Lion(string name = "Lionel", int age = 3, decimal weight = 10.0m, string color = "Golden") : base(name, age, weight, "Lion", "Savanna")
        {
            Color = color;

        }

        public string Hunt()
        {
            return $"{Name} is Hunting in savanna.";
        }

        public override string MakeSound()
        {
            return "ROAR!";
        }
        public override string ToString()
        {
            return base.ToString() + $", Color: {Color}";
        }

    }
}
