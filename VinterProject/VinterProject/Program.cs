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
    string[] names = { "forrest", "woods", "river" };
    string[] desc = { "You look around and see a path", "Also green", "blue" };
    string[] allowedPaths = { "a crossroad", "the beginning and a river", "a crossroad" };
    string[] plural = { "a", "multiple", "a" };

    while (playing == true)
    {
        bool hpLoss = false;

        System.Console.WriteLine($"You're currently in {names[location]} and have {life} lives left.");
        Console.WriteLine($"{desc[location]}");
        System.Console.WriteLine($"You see {plural[location]} path leading to {allowedPaths[location]}");

        choice = Console.ReadLine();

        if (choice == "river")
        {
            System.Console.WriteLine("yes");
        }


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
