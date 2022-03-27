using System;
public class Payments {
    public Payments() {
        //taking order payment
        string confirm = Console.ReadLine();

        //if order is not correct, allow customer to reorder
        if (!string.IsNullOrWhiteSpace(confirm) && confirm == "N") {
            Orders order = new Orders();
        }
        //Customer payment choice: credit card or debit card
        if (!string.IsNullOrWhiteSpace(confirm) && confirm == "Y") {
                CreditCard credit = new CreditCard();
        }
    }
}