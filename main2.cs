using System;

/* This declaration is a bit different to what we do in Unity,
but necessary in order to run this live snippet
*/
class MainClass {
    static void Main() {
        
        // addition
        float x = 1;
        float y = 1;
        float result = x + y;
        
        // show the result in the console
        // in Unity we use "print()" or "Debug.Log()"
        Console.WriteLine(result);
        
        // subtraction
        float health = 100;
        float damage = 90;
        
        // update the health variable
        health = health - damage;
        
        // show the result in the console
        Console.WriteLine(health);
        
        // multiplication
        float items = 100;
        float cost_per_item = 2;
        float total_cost = items * cost_per_item;
        
        // show the result in the console
        Console.WriteLine(total_cost);
        
        // division
        float gold = 1000;
        float players = 10;
        float gold_per_player = gold / players;
        
        // show the result in the console
        Console.WriteLine(gold_per_player);
        
    }
}