namespace BankEncapsulation
{
    public class Program
    {
        static void Main()
        {
            //create a new instance of the BankAccount class. 
            //Allow the user of the application to Deposit money and retrieve their balance through the console.

            BankAccountClass bankAccountVar = new BankAccountClass();
            Console.WriteLine($"Your current balance is: ${bankAccountVar.GetBalance():N2}.");
            Console.WriteLine("Please enter the amount you would like to deposit into your account: ");
            Console.Write("$");
            string depositVar = Console.ReadLine();
            bankAccountVar.DepositMethod(double.Parse(depositVar));
            Console.WriteLine($"You deposited ${depositVar}.");
            Console.WriteLine($"Your new balance is: ${bankAccountVar.GetBalance():N2}");
        }
    }
}
