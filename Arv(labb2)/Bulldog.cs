namespace Arv_labb2_
{
    public class Bulldog : Dog
    {
        public bool Lazy { get; set; } = true;
        public Bulldog(string name = "Bic", int age = 3, decimal weight = 5.3m , bool lazy = true) : base(name, age, weight, "Bulldog")
        {
            Lazy = lazy;
        }
        public string Rest()
        {
            if (Lazy)
            {
                return $"{Name} love to rest.";
            }
            else
            {
                return $"{Name} hates to rest.";
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Lazy: {Lazy}";
        }

    }
}
