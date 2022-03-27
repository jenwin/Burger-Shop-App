using System;
public class Payments {
    public Payments() {
        //taking order payment
        string confirm = Console.ReadLine();

        //customer payment choices: credit card or debit card
        //if customer order is correct, ask customer how they would like to pay
        if (!string.IsNullOrWhiteSpace(confirm) && confirm == "Y") {
            CreditCard credit = new CreditCard();
        }

        //if order is incorrect, allow customer to reorder
        if (!string.IsNullOrWhiteSpace(confirm) && confirm == "N") {
            Orders order = new Orders();
        }
    }
}