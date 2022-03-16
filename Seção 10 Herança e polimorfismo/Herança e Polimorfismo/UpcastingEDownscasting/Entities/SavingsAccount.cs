
namespace UpcastingEDownscasting.Entities
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
    }
}
