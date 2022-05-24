using System;
using System.Collections.Generic;
using System.Numerics;


Base();

static void Base() //Metoden som startar spelet
{

    bool playing = true;
    playing = Main(playing);

}

static bool Main(bool playing)   //Metoden som driver spelet
{

    bool unlockRequirement = false;  //Bool för om man har uppnåt kriterierna för att kunna lämna
    string replay = "yes"; //String som används för när man frågas om man vill fortsätta köra eller inte
    string choice = "notmade"; //String för rörelse, alltså till vilken location man vill gå
    int life = 3; //Int för liven man har
    int location = 0; //Int för vilken desc, loc, plural, s och allowedPaths.
    int run = 0; //Styr om man får optionen att lämna eller inte.
    List<string> names = new List<string>() { "glade", "forest", "river", "ruin", "grave", "log" }; //Lista på dem olika locations man kan gå
    string[] desc = { "You look around and see that you're in a open area surrounded by forest", "Also green", "blue", "You arrive at a crumbled old ruin with nothing noteworthy at first sight", "mysterious", "" }; //Array av beskrivningar av locations man är på
    string[] allowedPaths = { "a opening into the forest", "the glade, a river and a ruin", "a log over the river and the path back to the forest", "a grave", "the ruin", "" }; //Array som säger vart man kan gå beroende på location
    string[] plural = { "a", "multiple", "a", "a", "a", "a" }; //Array som byter ut språket som sägs beroende på om det är flera eller väg som man kan gå
    string[] escape = { "", ", you can now leave aswell" }; //Array som gömmer och sedan lägger till valet att lämna beoende på run inten
    string[] s = { "", "s", "", "", "", "" }; //Array som bara lägger till s på slutet av ett ord om det behövs för att vara gramatiskt korrekt
    while (playing == true) //En while loop som kör spelet till att playing = false
    {
        bool hpLoss = false; //bool som används för att veta om en användares handling gjorde att den förlorade liv

        if (unlockRequirement == true && location == 0) //If kommando som gör att man kan lämna och vinna spelet
        {
            run = 1;
        }

        System.Console.WriteLine($"You're currently in {names[location]} and have {life} lives left.");
        Console.WriteLine($"{desc[location]}");
        System.Console.WriteLine($"You see {plural[location]} path{s[location]} leading to {allowedPaths[location]}{escape[run]}"); //Alla tre har med att beskriva miljön, vart man är och vart man kan gå

        choice = Console.ReadLine().ToLower(); //Tar emot vart man vill gå

        if (names.Contains(choice) && choice == "forest") //If kommando som kollar vad som togs emot och flyttar en till annan location om kraven uppnås
        {
            if (allowedPaths[location] == "a opening into the forest" || allowedPaths[location] == "a log over the river and the path back to the forest" || allowedPaths[location] == "a grave") //Liknande innan så kollar den om den uppfyller kraven för att flytta till den specifierade locationen
            {
                System.Console.WriteLine("working forest"); //Kommando som ges vid bugtestning så att man vet om koden funkar
                location = 1; //Byter location
                choice = "notmade"; //Resetar choice så att while loopen kan repeteras utan problem
            }
        }

        if (names.Contains(choice) && choice == "river" && allowedPaths[location] == "the glade, a river and a ruin") //If kommando som kollar vad som togs emot och flyttar en till annan location om kraven uppnås
        {
            System.Console.WriteLine("working river"); //Kommando som ges vid bugtestning så att man vet om koden funkar
            location = 2; //Byter location
            choice = "notmade"; //Resetar choice så att while loopen kan repeteras utan problem
        }

        if (names.Contains(choice) && choice == "glade" && allowedPaths[location] == "the glade, a river and a ruin") //If kommando som kollar vad som togs emot och flyttar en till annan location om kraven uppnås
        {
            System.Console.WriteLine("working glade"); //Kommando som ges vid bugtestning så att man vet om koden funkar
            location = 0; //Byter location
            choice = "notmade"; //Resetar choice så att while loopen kan repeteras utan problem
        }

        if (names.Contains(choice) && choice == "ruin" && allowedPaths[location] == "the glade, a river and a ruin") //If kommando som kollar vad som togs emot och flyttar en till annan location om kraven uppnås
        {
            System.Console.WriteLine("working ruin"); //Kommando som ges vid bugtestning så att man vet om koden funkar
            location = 3; //Byter location
            choice = "notmade";
        }
        else if (names.Contains(choice) && choice == "ruin" && allowedPaths[location] == "the ruin") //If kommando som kollar vad som togs emot och flyttar en till annan location om kraven uppnås
        {
            System.Console.WriteLine("working ruin"); //Kommando som ges vid bugtestning så att man vet om koden funkar
            location = 3; //Byter location
            choice = "notmade"; //Resetar choice så att while loopen kan repeteras utan problem
        }

        if (names.Contains(choice) && choice == "log" && allowedPaths[location] == "a log over the river and the path back to the forest") //If kommando som kollar vad som togs emot och flyttar en till annan location om kraven uppnås
        {
            System.Console.WriteLine("You fell of the log and seemingly died by drowning");
            hpLoss = true;
        }

        if (names.Contains(choice) && choice == "grave" && allowedPaths[location] == "a grave") //If kommando som kollar vad som togs emot och flyttar en till annan location om kraven uppnås
        {
            System.Console.WriteLine("working grave"); //Kommando som ges vid bugtestning så att man vet om koden funkar
            System.Console.WriteLine("You see something shining on the ground while looking around.");
            System.Console.WriteLine("Do you wanna interact with it? yes/no");
            location = 4; //Byter location
            choice = Console.ReadLine().ToLower();

            if (choice == "yes") //Kollar om man interactat med graven och då gör unlockRequirment till sant
            {
                unlockRequirement = true;
                System.Console.WriteLine("You feel refreshed when interacting with it and feel as though a path has opened.");
            }

            choice = "notmade"; //Resetar choice så att while loopen kan repeteras utan problem

        }


        if (location == 0 && unlockRequirement == true && choice == "leave") //Kollar om man har uppnåt kraven för att avsluta spelet
        {
            System.Console.WriteLine("congrats you've escaped! Do you wanna play again? yes/no");
            playing = false; //Gör så att spelet avslutas

            if (replay == Console.ReadLine().ToLower()) //Resetar hela spelet från början om man skrivit yes till att spela om
            {
                playing = true;
                life = 3; //Resetar liv
                location = 0; //Byter location
                unlockRequirement = false; //Resetar unlockrequirement
                run = 0;
            }
        }

        if (life == 0) //Kollar om man dött och fått en gameover
        {
            System.Console.WriteLine("You don't have any more lives and therefore died for real man. Do you wanna play again?");
            playing = false; //Gör så att spelet avslutas
            if (replay == Console.ReadLine()) //Resetar hela spelet från början om man skrivit yes till att spela om
            {
                playing = true;
                life = 3; //Resetar liv
                location = 0; //Byter location
                unlockRequirement = false; //Resetar unlockrequirement
                run = 0;
            }
        }

        while (playing == true)
        {
            if (hpLoss == true)
            {
                life--; //Tar bort ett liv efter att en handling som gjort hploss = true
                location = 0; //Byter location
            }
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
