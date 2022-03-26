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
        }

        //check if the user signed up or not
        if ((!string.IsNullOrWhiteSpace(newUserName)) &&
            (!string.IsNullOrWhiteSpace(newPassword))) {
            Console.WriteLine("Thank you for signing up!");
        } else {
            Console.WriteLine("Sign Up!");
        }
    }
}    