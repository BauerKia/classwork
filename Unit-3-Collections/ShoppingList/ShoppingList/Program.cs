namespace ShoppingList;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> menuList = new Dictionary<string, double>();
        menuList.Add("apple", 0.99);
        menuList.Add("banana", 0.59);
        menuList.Add("cauliflower", 1.59);
        menuList.Add("dragonfruit", 2.19);
        menuList.Add("elderberry", 1.79);
        menuList.Add("figs", 2.09);
        menuList.Add("grapefruit", 1.99);
        menuList.Add("honeydew", 3.49);
        
        List<> cart = 
        
        Console.WriteLine("Welcome to Chirpus Market!");
        
        //Output of menuList
        //Menu only
        Console.WriteLine("Item             Price");
        Console.WriteLine("==============================");
        foreach (var m in menuList)
        {
            Console.WriteLine($"{m.Key}",m);
            Console.WriteLine($"${m.Value}", m);
        }
        
        Console.WriteLine("What item would you like to order? ");
        string input = Console.ReadLine();
        
        if (!menuList.ContainsKey($"{input}"))
        {
            Console.WriteLine("Sorry, we don't have those. Please try again.");
        }

        do
        {
            //Menu only
            Console.WriteLine("Item             Price");
            Console.WriteLine("==============================");
            foreach (var m in menuList)
            {
                Console.WriteLine($"{m.Key}          ${m.Value}",m);
                
            }
            
            //Getting user wants
            
            Console.WriteLine("What item would you like to order? ");
           input = Console.ReadLine().ToLower();
           
           //Adding to the list or checking if it is on the list
           if (!menuList.ContainsKey($"{input}"))
           {
               Console.WriteLine("Sorry, we don't have those. Please try again.");
           }
           // try/catch
           try
           {
               menuList.ContainsKey($"{input}");
               cart. 
           }
           catch
           {
               
           }

           Console.WriteLine("Would you like to order anything else (y/n)?");
            input = Console.ReadLine();
        } while (input == "y");
        
        Console.WriteLine("Thanks for your order!");
        Console.WriteLine("Here's what you got: {cart}");
        //cart
        //average of cart
        
    }
}