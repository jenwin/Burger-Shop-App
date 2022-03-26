using System;
public class SignUp {
    //create signup constructor
    public SignUp() {
        //signing up, choose a username
        Console.WriteLine("Choose a Username:");
        string newUserName = Console.ReadLine();

        Console.WriteLine("Choose a Password:");
        string newPassword = Console.ReadLine();

        //check if the user signed up or not
        if ((!string.IsNullOrWhiteSpace(newUserName)) &&
            (!string.IsNullOrWhiteSpace(newPassword))) {
            Console.WriteLine("Thank you for signing up!");
            //user is logged in, taking orders and payments!
            Orders order = new Orders();
            Payments payment = new Payments();
            } else {
            Console.WriteLine("Sign Up!");
        }
    }
}