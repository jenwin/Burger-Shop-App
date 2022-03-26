using System;
public class Payments {
    public Payments() {
        //taking order payment
        Console.WriteLine("Is this correct? [Y] or [N]");
            string confirm = Console.ReadLine();
            //credit card or debit card
            if (!string.IsNullOrWhiteSpace(confirm) && confirm == "Y") {
                Console.WriteLine("How would you like to pay?");
                Console.WriteLine("Credit Card [A] or Debit Card [B]");
                string payment = Console.ReadLine();
                //credit card
                if (!string.IsNullOrWhiteSpace(payment) && 
                    payment == "A") {
                        Console.WriteLine("Enter your credit card number:");
                        string creditString = Console.ReadLine();
                        Console.WriteLine("Please confirm payment. Is this correct? [Y]");
                        Console.WriteLine("If you would like to pay with another method of payment. [B]");
                        string confirmCreditPayment = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(confirmCreditPayment) &&
                            confirmCreditPayment == "Y") {
                                Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
                            }
                        //if customer chooses to pay with debit card after choosing credit first
                        if (!string.IsNullOrWhiteSpace(confirmCreditPayment) &&
                            confirmCreditPayment == "B") {
                                Console.WriteLine("Would you like to pay with a debit card?");
                                string payWithDebit = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(payWithDebit) &&
                                payWithDebit == "Y") {
                                    Console.WriteLine("Enter your debit card number:");
                                    string debitPayment = Console.ReadLine();

                                    Console.WriteLine("Please confirm payment. Is this correct? [Y]");
                                    string confirmDebitPayment = Console.ReadLine();
                                    if (!string.IsNullOrWhiteSpace(confirmDebitPayment) &&
                                        confirmDebitPayment == "Y") {
                                        Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
                                    }
                                }
                            }
                //debit card
                } else if (!string.IsNullOrWhiteSpace(payment) && 
                    payment == "B") {
                        Console.WriteLine("Enter your debit card number:");
                        string debitString = Console.ReadLine();
                        Console.WriteLine("Please confirm. Is this correct? [Y]");
                        string confirmDebitPayment = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(confirmDebitPayment) && 
                            confirmDebitPayment == "Y") {
                                Console.WriteLine("Thank you for your payment. Your order is being processed. We will notify when your order is ready.");
                            }
                    }
                }
    }
}