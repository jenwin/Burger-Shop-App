using System; // using sytem library in project, Console class or the WriteLine function/method

namespace LoginProgram {
    class User {
        static void Main(string[] args) {
            Console.WriteLine("Enter username");
            string name = Console.ReadLine();

            //checks to see if the name is not null or null
            if (!string.IsNullOrWhiteSpace(name)) {
                //checks to see if the password is not null or null
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(password)) {
                    Console.WriteLine("Logged in!");
                    
                    Console.WriteLine("Can I take your order? [Y] or [N]");
                    string takeOrder = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(takeOrder)) {
                    Console.WriteLine("Would you like tomatoes? [Y] or [N]");
                    string tomato = Console.ReadLine();
                    Console.WriteLine("Would you like lettuce? [Y] or [N]");
                    string lettuce = Console.ReadLine();
                    Console.WriteLine("Would you like cheese? [Y] or [N]");
                    string cheese = Console.ReadLine();
                    Console.WriteLine("Would you like tomatoes? [Y] or [N]");
                    string tomatoes = Console.ReadLine();
                    Console.WriteLine("Would you like sauce? [Y] or [N]");
                    string sauce = Console.ReadLine();
                    Console.WriteLine("Would you like bbq? [Y] or [N]");
                    string bbq = Console.ReadLine();
                    Console.WriteLine("Would you like ketchup? [Y] or [N]");
                    string ketchup = Console.ReadLine();
                    Console.WriteLine("Please confirm your order.");
                    // Dashboard order = new Dashboard("Y", "Y", "Y", "Y", "Y", "Y");
                    Console.WriteLine(
                        "Tomato: " + tomato + " " + 
                        "Lettuce: " + lettuce + " " + 
                        "Cheese: " + cheese + " " +
                        "Sauce: " + sauce + " " + 
                        "Bbq Sauce: " + bbq + " " + 
                        "Ketchup Sauce: " + ketchup);
                    Console.WriteLine("Is this correct? [Y] or [N]");
                    string confirm = Console.ReadLine();

                    //take payments
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

                } else if ((string.IsNullOrWhiteSpace(password))) {
                    Console.WriteLine("Password incorrect");
                }
            } else if ((string.IsNullOrWhiteSpace(name))) {
                if (name != null) {
                    Console.WriteLine("No Account? Signup here.");
                    //user signup page
                    SignUp signUpObj = new SignUp();
                }
            }
        }
    }
}