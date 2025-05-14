using System;
public class CreditCard {
    public CreditCard() {
        //when customer order is correct, ask how they would like to pay
        Console.WriteLine("Enter your credit card number:");
        string? payment = Console.ReadLine();

        //[Y] confirming if payment is correct
        //[C] goes back to payment options
        Console.WriteLine("Please confirm payment. Is this correct? [Y]");
        Console.WriteLine("Back to payment options. [C]");
        string? confirmCreditPayment = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(confirmCreditPayment) && confirmCreditPayment == "Y") {
            Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
        }

        //[C] option, if customer wants to go back to payment options
        if (!string.IsNullOrWhiteSpace(confirmCreditPayment) && confirmCreditPayment == "C") {
            BackToPaymentOptions paymentOptions = new BackToPaymentOptions();
        }

        //[B] if customer chooses debit payment option
         if (!string.IsNullOrWhiteSpace(payment) && payment == "B") {
            DebitCard debit = new DebitCard();
        }
    }
}