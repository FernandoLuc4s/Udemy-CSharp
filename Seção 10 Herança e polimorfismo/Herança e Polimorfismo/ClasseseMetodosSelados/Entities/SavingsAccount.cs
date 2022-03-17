
namespace  ClasseseMetodosSelados.Entities
{
     class SavingsAccount : Account // sealed = classe selada, isso significa que a classe não pode ser herdada
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            :base(number, holder, balance) // reaproveitando construtor
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) // override = sobrescrita de metodo, sealed = indica que o metodo não pode ser sobreescrito novamente
        {
            base.Withdraw(amount); // a palavra base permite que você pegue o mesmo metódo da superclasse e depois implemente algo usando a sobreposição
            Balance -= 2.0;
        }
    }
}
