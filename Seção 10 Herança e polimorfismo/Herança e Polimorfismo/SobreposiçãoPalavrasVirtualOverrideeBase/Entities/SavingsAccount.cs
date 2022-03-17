
namespace SobreposiçãoPalavrasVirtualOverrideeBase.Entities
{
    class SavingsAccount : Account
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

        public override void Withdraw(double amount) // override = sobrescrita de metodo
        {
            base.Withdraw(amount); // a palavra base permite que você pegue o mesmo metódo da superclasse e depois implemente algo usando a sobreposição
            Balance -= 2.0;
        }
    }
}
