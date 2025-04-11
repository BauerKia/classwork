namespace DiceRoller;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, we will be rolling a pair of dice");
        Console.WriteLine("Please enter the number of sides of the first die: ");
        int die1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter the number of sides of the second die: ");
        int die2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Do you want to roll the dice? (y/n):  ");
        string input = Console.ReadLine();

        do
        {
             var rando = RandoNum(die1, die2);
                if (die1 == 6 && die2 == 6)
                { 
                    Console.WriteLine(WhatCombo(rando.rDie1, rando.rDie2));
                  Console.WriteLine(DidWin(rando.rDie1, rando.rDie2));
                }
            Console.WriteLine($"You got {rando.rDie1} and {rando.rDie2}. Your total is {rando.total}!");
            Console.WriteLine("Do you want to roll the dice again? (y/n):  ");
            input = Console.ReadLine();
        } while (input == "y");
    }

    //Random class
    //Within a specified range -> 2 parameters
    //returns meaningful typ -> Int
    //Can return tuples
    
    /*
     * Learn
     *  "out" parameters to make accessing return tuple easier to understand
     */
    static (int rDie1, int rDie2, int total) RandoNum(int range1, int range2)
    {
        Random rnd = new Random();
        int rDie1 = rnd.Next(1, range1);
        int rDie2 = rnd.Next(1, range1);
        int total = rDie1 + rDie2;

        return (rDie1, rDie2, total);

    }

    static string WhatCombo(int rD1, int rD2)
    {
        if (rD1 == 1 && rD2 == 1)
        {
            return "You got two 1s: Snake Eyes!";
            //How would i make this more friendly?
        }else if (rD1 == 1 && rD2 == 2 || rD1 == 2 && rD2 == 1)
        {
            return "A 1 and a 2: You got an Ace Deuce!";
        } else if (rD1 == 6 && rD2 == 6)
        {
            return "A 6 and a 6, Kind of like Tracy Chapman? You got Box Cars";
        }
        else
        {
            return "";
        }

    }

    static string DidWin(int rD1, int rD2)
    {
        int total = rD1 + rD2;
        if (total == 7 || total == 11)
        {
            return $"Congratulation! You won the roll! with {total}";
        }else if (total == 2 || total == 3 || total == 12)
        {
            return $"Big Oof! You the the roll! with {total}";
        }
        else
        {
            return "";
        }
    }

}