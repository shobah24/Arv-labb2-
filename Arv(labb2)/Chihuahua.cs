namespace Arv_labb2_
{
    public class Chihuahua : Dog
    {
        public int BarkEnergy { get; set; } = 5;

        public Chihuahua(string name = "Chi", int age = 2, decimal weight = 3.5m , int barkEnergy = 5) : base(name, age, weight, "Chihuahua")
        {
            BarkEnergy = barkEnergy;
        }
        public string Run()
        {
            if (BarkEnergy >= 5)
            {
                return $"{Name} is running with much energy.";
            }
            else
            {
                return $"{Name} is running with not so much energy.";
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", Bark Energy: {BarkEnergy}";
        }
    }
}
