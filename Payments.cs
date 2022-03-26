using System;
public class Payments {
    public Payments() {
        Console.WriteLine("Is this correct? [Y] or [N]");
            string confirm = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(confirm) && confirm == "Y") {
                Console.WriteLine("How would you like to make your payment?");
                Console.WriteLine("Credit Card [A] r Debit Card [B]");
                string payment = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(payment) && 
                    payment == "A") {
                        Console.WriteLine("Enter your credit card number");
                        string creditString = Console.ReadLine();
                        Console.WriteLine("Please confirm. Is this correct?");
                        string confirmCreditPayment = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(confirmCreditPayment) &&
                            confirmCreditPayment == "Y") {
                                Console.WriteLine("Thank you for your payment. Your order is being processed.");
                            }
                } else if (!string.IsNullOrWhiteSpace(payment) && 
                    payment == "B") {
                        Console.WriteLine("Enter your debit card number");
                        string debitString = Console.ReadLine();
                        Console.WriteLine("Please confirm. Is this correct?");
                        string confirmDebitPayment = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(confirmDebitPayment) && 
                            confirmDebitPayment == "Y") {
                                Console.WriteLine("Thank you for your payment. Your order is being processed.");
                            }
                    }
                }
    }
}