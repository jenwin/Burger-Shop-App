using System;

public class Dashboard {
    //data members
    public string tomato;
    public string lettuce;
    public string cheese;
    public string sauce;
    public string bbq;
    public string ketchup;
    //create dashboard constructor
    public Dashboard(string tomato, string cheese, string lettuce, string sauce, 
    string bbq, string ketchup) {
        this.tomato = tomato;
        this.cheese = cheese;
        this.lettuce = lettuce;
        this.sauce = sauce;
        this.bbq = bbq;
        this.ketchup = ketchup;
    }
}