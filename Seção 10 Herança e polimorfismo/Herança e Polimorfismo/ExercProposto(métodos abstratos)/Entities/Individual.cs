namespace ExercProposto_metodos_abstratos_.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpedentures { get; set; }

        public Individual(double healthExpedentures, string name, double anualIncome)
            :base(name, anualIncome)
        {
            HealthExpedentures = healthExpedentures;
        }
        public override double Tax()
        {
            if (AnualIncome < 2000.00) {
                return (AnualIncome * 0.15) - (HealthExpedentures * 0.5);
            }
            else 
            {
                return (AnualIncome * 0.25) - (HealthExpedentures * 0.5);
            }
        }
    }
}
