using System;
public class OptionC {
    public OptionC() {
        Console.WriteLine("How would you like to pay?");
        Console.WriteLine("Credit Card [A] or Debit Card [B]");
        string payment = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(payment) && payment == "A") {
            CreditCard credit = new CreditCard();
            }
        if (!string.IsNullOrWhiteSpace(payment) && payment == "B") {
            DebitCard debit = new DebitCard();
        }
}
}