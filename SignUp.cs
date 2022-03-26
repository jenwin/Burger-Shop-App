using System;
public class SignUp {
    //create signup constructor
    public SignUp() {
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
        }
}    