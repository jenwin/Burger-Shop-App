using System;
public class BackToPaymentOptions {
    public BackToPaymentOptions() {
        Console.WriteLine("How would you like to pay?");
        Console.WriteLine("Credit Card [A] or Debit Card [B]");
        string? payment = Console.ReadLine();

        //[A] for credit card payment option
        if (!string.IsNullOrWhiteSpace(payment) && payment == "A") {
            CreditCard credit = new();
        }

        //[B] for debit card payment option
        if (!string.IsNullOrWhiteSpace(payment) && payment == "B") {
            DebitCard debit = new();
        }
    }
}