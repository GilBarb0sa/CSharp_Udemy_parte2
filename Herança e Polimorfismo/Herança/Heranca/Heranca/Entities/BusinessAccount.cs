namespace Heranca.Entities
{
    class BusinessAccount : Account  //Subclasse - Esta classe herda tudo que tem na classe Account, se tornando subclase
    {
        public double LoanLimit { get; set; }
        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) //atribui todas as propriedades de Account
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
