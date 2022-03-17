

namespace  ClasseseMetodosSelados.Entities
{
    class BusinessAccount : Account  // criando herança da account para business account 
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount( int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) // aproveitando o construtor da superclasse
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) 
        {
            if (amount <= LoanLimit) 
            { 
                Balance += amount;
            }
        }
    }
}
