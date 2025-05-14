using System;
public class SignUp {
    //create signup constructor
    public SignUp() {
        //signing up, choose a username
        Console.WriteLine("Choose a Username:");
        string? newUserName = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Choose a Password:");
        string? newPassword = Console.ReadLine() ?? string.Empty;

        //check if the user signed up or not
        if ((!string.IsNullOrWhiteSpace(newUserName)) &&
            (!string.IsNullOrWhiteSpace(newPassword))) {
            Console.WriteLine("Thank you for signing up!");
            //user is logged in, taking orders!
            Orders order = new();
            } else {
            Console.WriteLine("Sign Up!");
        }
    }
}