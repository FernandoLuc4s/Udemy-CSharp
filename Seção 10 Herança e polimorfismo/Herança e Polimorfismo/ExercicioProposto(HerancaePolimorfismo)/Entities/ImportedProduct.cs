namespace ExercicioProposto_HerancaePolimorfismo_.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(double customsFee, string name, double price)
            :base( name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + " (Customs fee: $ " + CustomsFee.ToString("F2") + ")";
        }
    }
}
