using System;
using System.Collections.Generic;
using System.Numerics;


Base();

static void Base()
{

    bool playing = true;
    playing = Main(playing);

}

static bool Main(bool playing)
{

    int life = 3;
    string replay = "placeholder";
    string choice = "notmade";
    int location = 0;
    List<string> names = new List<string>() { "glade", "forest", "river", "ruin" };
    string[] desc = { "You look around and see that you're in a open area surrounded by forest", "Also green", "blue", "You arrive at a crumbled old ruin with nothing noteworthy at first sight" };
    string[] allowedPaths = { "a crossroad", "the glade and a river", "a crossroad" };
    string[] plural = { "a", "multiple", "a" };

    while (playing == true)
    {
        bool hpLoss = false;

        System.Console.WriteLine($"You're currently in {names[location]} and have {life} lives left.");
        Console.WriteLine($"{desc[location]}");
        System.Console.WriteLine($"You see {plural[location]} path leading to {allowedPaths[location]}");

        choice = Console.ReadLine().ToLower();

        if (names.Contains(choice) && choice == "forest" && allowedPaths[location] == "a crossroad")
        {
            System.Console.WriteLine("working forest");
            location = 1;
            choice = "notmade";
        }

        if (names.Contains(choice) && choice == "river")
        {
            System.Console.WriteLine("working river");
            location = 2;
            choice = "notmade";
        }

        if (names.Contains(choice) && choice == "glade" && allowedPaths[location] == "the glade and a river")
        {
            System.Console.WriteLine("working glade");
            location = 0;
            choice = "notmade";
        }

        //  if (names.Contains(choice) && location  





        // System.Console.WriteLine("You look around and see nothing");

        // Vart vill du gå?
        // w = readline
        // Om allwedpaths[location].contains("w")
        // if (allowedPaths[location].Contains("1"))
        // {

        // }
        // 


        // location = Console.ReadLine();


        // if (location == "you")
        // {
        //     location = "yes";
        // }

        // if (location == "die")
        // {
        //     location = "beginning";
        //     hpLoss = true;
        // }

        // if (hpLoss == true)
        // {
        //     life--;
        // }

        // if (life == 0)
        // {
        //     playing = false;
        // }

        // if (location == "leave")
        // {
        //     playing = false;
        // }

        // if (location == "leave")
        // {
        //     System.Console.WriteLine("Thanks for playing, hope you enjoyed!");
        // }
        // else if (life == 0)
        // {
        //     System.Console.WriteLine("Oops, you appear to have died. Do you wanna play more?");
        //     replay = Console.ReadLine();

        // }

        if (replay == "yes")
        {
            playing = true;
            life = 3;
        }
        Console.ReadLine();
    }

    return playing;

}

void tryparse(int v)
{
    throw new NotImplementedException();
}