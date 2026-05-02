Console.WriteLine("Welcome to carpet cleaning service\nPlease enter your name?\nEnter your name:");
string? name = Console.ReadLine();
Console.WriteLine($"Hello Mr {name}\nPlease enter number of small carpets rooms you need to clean :");
int numberOfSmallCarpets = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Please enter number of Large carpets rooms you need to clean :");
int numberOfLargeCarpets = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"the total price of small carpet rooms cleaning is : {numberOfSmallCarpets * 250:C} \n");
Console.WriteLine($"the total price of Large carpet rooms cleaning is : {numberOfLargeCarpets * 350:C} \n");
int totalCost = (numberOfSmallCarpets * 250) + (numberOfLargeCarpets * 350);
Console.WriteLine($"the total cost : {totalCost:C}");
double totalTax = totalCost * 0.14;
Console.WriteLine($"Tax: {totalTax:C} ");
double totalEstimation = (double)totalCost + totalTax;
Console.WriteLine($"Total estimation : { totalEstimation:C} ");






