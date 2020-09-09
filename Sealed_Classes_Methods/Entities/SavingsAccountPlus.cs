namespace Sealed_Classes_Methods.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {   
        //Este método não pode ser executado pois foi selado no método sobrescrito da classe 'SavingsAccount'
        public override void Withdraw(double amount)
        {

        }
    }
}
