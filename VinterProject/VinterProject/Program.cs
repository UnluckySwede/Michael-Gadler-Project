using System;
using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;

Base();

static void Base()
{

    string location = "Beginning";

    bool playing = true;

    if (playing == true)
    {
        Main(location, playing);
    }
}

static void Main(string location, bool playing)
{
    int life = 1;
    bool replay = false;

    System.Console.WriteLine($"You're currently in {location}");





    if (location != "beginning" && life == 0 && replay == true)
    {
        location = "beginning";
        life = 1;
    }

    if (location == "blyat")
    {
        playing = false;
    }
    Console.ReadLine();

}
