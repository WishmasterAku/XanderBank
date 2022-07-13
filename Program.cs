// See https://aka.ms/new-console-template for more information
public class Customer
{
    string? cardNumber;
    int pinNum;
    string? firstName;
    string? lastName;
    double balance;
    public Customer(string? cardNumber, int pinNum, string? firstName, string? lastName, double balance)
    {
        this.cardNumber = cardNumber;
        this.pinNum = pinNum;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public String? getNum()
    {
        return cardNumber;
    }
    public int getPin()
    {
        return pinNum;
    }
    public String? getFirstName()
    {
        return firstName;
    }
    public String? getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setNum(String? newCardNumber)
    {
        cardNumber = newCardNumber;
    }
    public void setPin(int newPinNum)
    {
        pinNum = newPinNum;
    }
    public void setFirstName(string? newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(string? newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
    public static void Main(String[] args)
    {
        void MainMenu()
        {
        System.Console.WriteLine("Welcome to Xander Bank");
        System.Console.WriteLine("Please enter your customer number");
        System.Console.WriteLine("Please select an option");
        System.Console.WriteLine("1) Withdraw");
        System.Console.WriteLine("2) Deposit");
        System.Console.WriteLine("3) Show Balance");
        System.Console.WriteLine("4) Sign off");
        }

        void Deposit(Customer currentuser, double newBalance)
        {
            System.Console.WriteLine("Please enter the amount you want to deposit");
            double Deposit = Convert.ToDouble(Console.ReadLine());
            currentuser.setBalance(Deposit + newBalance);
            System.Console.WriteLine("Deposit Accepted. Your new balance is: " + currentuser.getBalance());   
        }

        void Withdraw(Customer currentuser, double newBalance)
        {
            System.Console.WriteLine("Please enter the amount you want to withdraw");
            double Withdraw = Convert.ToDouble(Console.ReadLine());
            currentuser.setBalance(newBalance - Withdraw);
            System.Console.WriteLine("Your ending balance is: " + currentuser.getBalance());
        }
        void ShowBalance(Customer currentuser, double balance)
        {
            System.Console.WriteLine("Your current balance is: " + currentuser.getBalance());
        }
        
        
    }

}