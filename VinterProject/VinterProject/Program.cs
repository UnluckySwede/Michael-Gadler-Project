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
    while (playing == true)
    {
        int life = 1;

        System.Console.WriteLine($"You're currently in {location}");
        System.Console.WriteLine("You look around and see nothing");

        location = Console.ReadLine();

        if (location == "you")
        {
            location = "yes";
        }




        if (location != "beginning" && life == 0)
        {
            location = "blyat";
            life = 1;
        }

        if (location == "blyat")
        {
            playing = false;
        }
        Console.ReadLine();

    }

    return (location, playing);

}
