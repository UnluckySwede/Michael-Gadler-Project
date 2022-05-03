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

    bool unlockRequirement = false;
    string replay = "yes";
    string choice = "notmade";
    int life = 3;
    int location = 0;
    int run = 0;
    List<string> names = new List<string>() { "glade", "forest", "river", "ruin", "grave", "log" };
    string[] desc = { "You look around and see that you're in a open area surrounded by forest", "Also green", "blue", "You arrive at a crumbled old ruin with nothing noteworthy at first sight", "mysterious", "" };
    string[] allowedPaths = { "a opening into the forest", "the glade, a river and a ruin", "a log over the river and the path back to the forest", "a grave", "the ruin", "" };
    string[] plural = { "a", "multiple", "a", "a", "a", "a" };
    string[] escape = { "", ", you can now leave aswell" };
    string[] s = { "", "s", "", "", "", "" };
    while (playing == true)
    {
        bool hpLoss = false;

        if (unlockRequirement == true && location == 0)
        {
            run = 1;
        }

        System.Console.WriteLine($"You're currently in {names[location]} and have {life} lives left.");
        Console.WriteLine($"{desc[location]}");
        System.Console.WriteLine($"You see {plural[location]} path{s[location]} leading to {allowedPaths[location]}{escape[run]}");

        choice = Console.ReadLine().ToLower();

        if (names.Contains(choice) && choice == "forest")
        {
            if (allowedPaths[location] == "a opening into the forest" || allowedPaths[location] == "a log over the river and the path back to the forest" || allowedPaths[location] == "a grave")
            {
                System.Console.WriteLine("working forest");
                location = 1;
                choice = "notmade";
            }
        }

        if (names.Contains(choice) && choice == "river" && allowedPaths[location] == "the glade, a river and a ruin")
        {
            System.Console.WriteLine("working river");
            location = 2;
            choice = "notmade";
        }

        if (names.Contains(choice) && choice == "glade" && allowedPaths[location] == "the glade, a river and a ruin")
        {
            System.Console.WriteLine("working glade");
            location = 0;
            choice = "notmade";
        }

        if (names.Contains(choice) && choice == "ruin" && allowedPaths[location] == "the glade, a river and a ruin")
        {
            System.Console.WriteLine("working ruin");
            location = 3;
            choice = "notmade";
        }
        else if (names.Contains(choice) && choice == "ruin" && allowedPaths[location] == "the ruin")
        {
            System.Console.WriteLine("working ruin");
            location = 3;
            choice = "notmade";
        }

        if (names.Contains(choice) && choice == "log" && allowedPaths[location] == "a log over the river and the path back to the forest")
        {
            System.Console.WriteLine("You fell of the log and seemingly died by drowning");
            hpLoss = true;
        }

        if (names.Contains(choice) && choice == "grave" && allowedPaths[location] == "a grave")
        {
            System.Console.WriteLine("working grave");
            System.Console.WriteLine("You see something shining on the ground while looking around.");
            System.Console.WriteLine("Do you wanna interact with it? yes/no");
            location = 4;
            choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                unlockRequirement = true;
                System.Console.WriteLine("You feel refreshed when interacting with it and feel as though a path has opened.");
            }

            choice = "notmade";

        }


        if (location == 0 && unlockRequirement == true && choice == "leave")
        {
            System.Console.WriteLine("congrats you've escaped! Do you wanna play again? yes/no");
            playing = false;

            if (replay == Console.ReadLine().ToLower())
            {
                playing = true;
                life = 3;
                location = 0;
                unlockRequirement = false;
                run = 0;
            }
        }

        if (life == 0)
        {
            System.Console.WriteLine("You don't have any more lives and therefore died for real man. Do you wanna play again?");
            playing = false;
            if (replay == Console.ReadLine())
            {
                playing = true;
                life = 3;
                location = 0;
                unlockRequirement = false;
                run = 0;
            }
        }

        if (hpLoss == true)
        {
            life--;
            location = 0;
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

        System.Console.WriteLine("");
        System.Console.WriteLine("");
        System.Console.WriteLine("");
    }

    return playing;

}
