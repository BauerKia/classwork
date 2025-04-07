// See https://aka.ms/new-console-template for more information
Console.Write("Write something:");
string input = Console.ReadLine();
Console.WriteLine($"{input}");

Console.Write("Enter a Number:");
string input2 = Console.ReadLine();
int num = int.Parse(input2);
num += 1;
Console.WriteLine($"{num}");

Console.Write("Enter a Number:");
string input3 = Console.ReadLine();
double num2 = double.Parse(input3);
num2 = num2 + 0.5;
Console.WriteLine($"{num2}");

Console.Write("Enter a Number:");
string input4 = Console.ReadLine();
double num3 = double.Parse(input4);
Console.Write("Enter another Number:");
string input5 = Console.ReadLine();
double num4 = double.Parse(input5);
Console.WriteLine($"The sum is {num3 + num4}");

Console.Write("Enter a Number:");
string input6 = Console.ReadLine();
double num5 = double.Parse(input6);
Console.Write("Enter another Number:");
string input7 = Console.ReadLine();
double num6 = double.Parse(input7);
Console.WriteLine($"The product is {num5 * num6}");

Console.Write("Enter a Number:");
string input8 = Console.ReadLine();
int num7 = int.Parse(input8);
Console.Write("Enter another Number:");
string input9 = Console.ReadLine();
int num8 = int.Parse(input9);
Console.WriteLine($"The product is {num7 / num8}");

Console.Write("Enter a Boolean:");
string input10 = Console.ReadLine();
Console.WriteLine($"You entered: {input10}");
if (input10 == "True")
{
    Console.WriteLine("The opposite of what you entered is: False");
}
else
{
    Console.WriteLine("The opposite of what you entered is: True");
}