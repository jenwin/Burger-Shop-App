using System;
public class DebitCard {
    public DebitCard() {
        //debit card payment
        Console.WriteLine("Enter your debit card number:");
        string payment = Console.ReadLine() ?? string.Empty;

        //[Y] to confirm debit payment
        //[C] goes back to other payment options
        Console.WriteLine("Is this correct? [Y]");
        Console.WriteLine("Back to payment options. [C]");
        string confirmDebitPayment = Console.ReadLine() ?? string.Empty;
        if (!string.IsNullOrWhiteSpace(confirmDebitPayment) && confirmDebitPayment == "Y") {
            Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
        }

        //[C] goes back to other payment options
        if (!string.IsNullOrWhiteSpace(confirmDebitPayment) && confirmDebitPayment == "C") {
            BackToPaymentOptions paymentOptions = new();
        }

        //[B] goes back to debit payment option
        if (!string.IsNullOrWhiteSpace(payment) && payment == "B") {
            Console.WriteLine("Enter your debit card number:");
            string newPaymentD = Console.ReadLine() ?? string.Empty;

            //[Y] asks custumer to confirm debit payment
            Console.WriteLine("Please confirm payment. Is this correct? [Y]");
            string newPaymentConfirm = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(newPaymentConfirm) && newPaymentConfirm == "Y") {
                Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
            }
        }

        //[A] for credit card payment option
        if (!string.IsNullOrEmpty(payment) && payment == "A") {
            CreditCard credit = new();
        }
    }
}