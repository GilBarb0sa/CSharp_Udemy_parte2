namespace MetodoAbstrato.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000 && HealthExpenditures == 0)
            {
                AnualIncome = AnualIncome * 0.15;
            }
            else if (AnualIncome < 20000 && HealthExpenditures > 0)
            {
                AnualIncome = (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else if (AnualIncome >= 20000 && HealthExpenditures == 0)
            {
                AnualIncome = AnualIncome * 0.25;
            }
            else if (AnualIncome >= 20000 && HealthExpenditures > 0)
            {
                AnualIncome = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }

            return AnualIncome;
        }
    }
}
