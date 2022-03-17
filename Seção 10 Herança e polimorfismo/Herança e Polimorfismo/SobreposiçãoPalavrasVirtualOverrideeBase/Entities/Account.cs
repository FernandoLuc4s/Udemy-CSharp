namespace SobreposiçãoPalavrasVirtualOverrideeBase.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) { // virtual = metodo pode ser sobrescrito ou sobreposto nas subclasses
            Balance -= amount +5.0; // incluindo taxa de conta comum
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
