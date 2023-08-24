using System; // using system library in project, Console class or the WriteLine function/method

namespace LoginProgram {
    class User {
        static void Main(string[] args) {
            Console.WriteLine("Enter username:");
            string name = Console.ReadLine();

            //checks to see if the name is not null or null
            if (!string.IsNullOrWhiteSpace(name)) {
                //checks to see if the password is not null or null
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(password)) {
                    Console.WriteLine("You are logged in!");    
                    //taking orders!
                    Orders order = new Orders();
                    //taking payments
                    Payments payment = new Payments();
                } else if ((string.IsNullOrWhiteSpace(password))) {
                    Console.WriteLine("Incorrect Password.");
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