using System;
public class SignUp {
    //create signup constructor
    public SignUp() {
        //user chooses username and password
        Console.WriteLine("Choose a Username.");
        string newUserName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newUserName)) {
            Console.WriteLine("Username created.");
        }
        Console.WriteLine("Choose a Password.");
        string newPassword = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newPassword)) {
            Console.WriteLine("Password created.");

        //check if the user signed up or not
        if ((!string.IsNullOrWhiteSpace(newUserName)) &&
            (!string.IsNullOrWhiteSpace(newPassword))) {
            Console.WriteLine("Thank you for signing up!");
            //logged in!
            //taking orders!
            Orders dashboardObj = new Orders();
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
        } else {
            Console.WriteLine("Sign Up!");
        }
    }
}