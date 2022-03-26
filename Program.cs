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