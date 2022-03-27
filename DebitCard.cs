using System;

public class DebitCard {
    public DebitCard() {
        //debit card payment
        // Console.WriteLine("How would you like to pay?");
        // Console.WriteLine("Credit Card [A] or Debit Card [B]");
        string payment = Console.ReadLine();
        Console.WriteLine("Enter your debit card number:");
        string debitString = Console.ReadLine();
        Console.WriteLine("Please confirm. Is this correct? [Y]");
        Console.WriteLine("Back to payment options. [C]");
        string confirmDebitPayment = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(confirmDebitPayment) && confirmDebitPayment == "Y") {
            Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
        }

        if (!string.IsNullOrWhiteSpace(confirmDebitPayment) && confirmDebitPayment == "C") {
            OptionC c = new OptionC();
        }

        if (!string.IsNullOrWhiteSpace(payment) && payment == "B") {
            Console.WriteLine("Enter your debit card number:");
            string newPaymentD = Console.ReadLine();
            Console.WriteLine("Please confirm payment. Is this correct? [Y]");
            string newPaymentConfirm = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newPaymentConfirm) && newPaymentConfirm == "Y") {
                    Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
                }
            }
        if (!string.IsNullOrEmpty(payment) && payment == "A") {
            CreditCard credit = new CreditCard();
        }
    }
}