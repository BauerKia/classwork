using System.Diagnostics;

namespace ShoppingList;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> menuList = new Dictionary<string, double>();
        //Extended? Find another method to display from most -> least expensive
        menuList.Add("honeydew", 3.49);
        menuList.Add("dragonfruit", 2.19);
        menuList.Add("figs", 2.09);
        menuList.Add("grapefruit", 1.99);
        menuList.Add("elderberry", 1.79);
        menuList.Add("cauliflower", 1.59);
        menuList.Add("apple", 0.99);
        menuList.Add("banana", 0.59);
        

        //List of String
        List<string> cart = new List<string>();
        string input = "";
        do
        {
            //menu
            // Extended? Use Switch case to have the menu system be num or letter
            // How to format the menu to make it look nicer?
            Console.WriteLine("Item Price");
            Console.WriteLine("=========================");
            foreach (var m in menuList)
            {
                Console.WriteLine($"{m.Key} -> ${m.Value}");
            }
            
            Console.WriteLine("What item would you like to order? ");
            input = Console.ReadLine().ToLower();
            if (!menuList.ContainsKey($"{input}"))
            {
                Console.WriteLine("Sorry, we don't have those. Please try again.");
            }else
            {
                cart.Add($"{input}");
                Console.WriteLine($"Adding {input} to cart at {menuList[$"{input}"]}");
            }

            Console.WriteLine("Would you like to order anything else (y/n)?");
            input = Console.ReadLine().ToLower();
        } while (input == "y");

        //Cart + Average
        Console.WriteLine("Thanks for your order!");
        Console.WriteLine("Here's what you got: ");
        double sum = 0.0;
        foreach (var c in cart)
        {
            //Extended? Somehow use .Sort() when comparing c in the menuList to check the value and adjust when it is printed?
            Console.WriteLine($"{c} ${menuList[c]}");
            sum = sum + menuList[c];
        }
        Console.WriteLine($"Your total is {sum}");
        Console.WriteLine($"Average price per item in order was {sum / cart.Count}");
    }
}