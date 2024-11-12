namespace Heranca.Entities
{
    sealed class SavingsAccount : Account 
    //Subclasse - sealed nenhuma outra classe não pode herdar esta classe
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance) //Base é usado tbm para reaproveitar o construtor da superclasse
        {
            InterestRate = interestRate;
        }
         
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) 
        //Pode-se selar somente metodos que tem sobreposição e ela não pode ser sobrescrita novamente 
        //Sobrescrito, devido ao virtual na superclasse Account
        {
            base.Withdraw(amount); //Puxa o metodo padrão da superclasse e acrescenta um desconto de 2
            Balance -= 2;
        }
    }
}
