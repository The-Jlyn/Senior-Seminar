using System;

/* This declaration is a bit different to what we do in Unity,
but necessary in order to run this live snippet
*/
class MainClass {
    static void Main() {
        
        // declaring our variables
        int score = 0;
        float speed = 3.5f;
        bool gameOver = false;
        string item = "Hat";
        
        // show the result in the console
        // in Unity we use "print()" or "Debug.Log()"
        Console.WriteLine(score);
        Console.WriteLine(speed);
        Console.WriteLine(gameOver);
        Console.WriteLine(item);
    }
}