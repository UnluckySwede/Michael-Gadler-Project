using System;
using System.Collections.Generic;
using System.Numerics;


Base();

static void Base()
{

    string location = "Beginning";
    bool playing = true;
    (location, playing) = Main(location, playing);

}

static (string, bool) Main(string location, bool playing)
{
    int life = 3;
    string replay = "placeholder";

    while (playing == true)
    {
        bool hpLoss = false;

        System.Console.WriteLine($"You're currently in {location} and have {life} lives left.");
        System.Console.WriteLine("You look around and see nothing");

        location = Console.ReadLine();


        if (location == "you")
        {
            location = "yes";
        }

        if (location == "die")
        {
            location = "beginning";
            hpLoss = true;
        }

        if (hpLoss == true)
        {
            life--;
        }

        if (life == 0)
        {
            playing = false;
        }

        if (location == "leave")
        {
            playing = false;
        }

        if (location == "leave")
        {
            System.Console.WriteLine("Thanks for playing, hope you enjoyed!");
        }
        else if (life == 0)
        {
            System.Console.WriteLine("Oops, you appear to have died. Do you wanna play more?");
            replay = Console.ReadLine();

        }

        if (replay == "yes")
        {
            playing = true;
            life = 3;
        }
        Console.ReadLine();
    }

    return (location, playing);

}
