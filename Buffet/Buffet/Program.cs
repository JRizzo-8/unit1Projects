
bool breakpoint = false;
while (breakpoint == false)
{
    Console.WriteLine("Hi! Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee How many people are in your group? Parties of 6 or lower only please.");
    String group = Console.ReadLine();
    int Group;
    Int32.TryParse(group, out Group);
    if (Group > 6)
    {
        Console.WriteLine("Sorry, you may only seat up to 6 people, have a great day!");
        break;
    }
    Console.WriteLine("A table for " + Group + "! Please follow me and take a seat.\n");
    Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.\n");

    int person = 1;
    int water = 0;
    int coffee = 0;

    do
    {
        Console.WriteLine("Alright, person number " + person + ", water or coffee?\n");
        string drinkchoice = Console.ReadLine().ToLower();
        if (drinkchoice == "water")
        {water++; Console.WriteLine(drinkchoice + ", good choice!");}
        else if (drinkchoice == "coffee")
        {coffee++; Console.WriteLine(drinkchoice + ", got it!");}
        else
        { Console.WriteLine("No drink for you? Got it!");}
        person++;
    }
    while (person <= Group);


    Console.WriteLine("Okay, so thats " + water + " waters and " + coffee + " coffees. I'll be right back. Feel Free to grab your food!\n");
    decimal buffetcost = 9.99m;
    decimal coffeetotal = coffee * 2;
    decimal total = Group * buffetcost + coffeetotal;
    Console.WriteLine("Here's your bill! Total price: $" + total);
}





