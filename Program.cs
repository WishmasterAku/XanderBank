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

    }

}