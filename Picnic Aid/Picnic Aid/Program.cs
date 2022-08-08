bool again = false;

while (again == false){
    Console.Write("Hello, How many people will you be making PB&J sandiwches for?: ");
    string userInput = Console.ReadLine();

    int TotalGuests;
    Int32.TryParse(userInput, out TotalGuests);
    Console.WriteLine("You will need:\n");
    int bread = TotalGuests * 2;
    int PB = TotalGuests * 2;
    int Jelly = TotalGuests * 4;
    Console.WriteLine(bread + " Slices of bread");
    Console.WriteLine(PB + " Tablespoons of peanut butter");
    Console.WriteLine(Jelly + " Teaspoons of jelly\n");
    Console.WriteLine("which is...\n");
    double loaf = Math.Round((double)bread / 28);
    double jar1 = Math.Round((double)PB / 32);
    double Jar2 = Math.Round((double)Jelly / 48);

    Console.WriteLine(loaf + " Loaves of bread");
    Console.WriteLine(jar1 + " Jars of peanut butter");
    Console.WriteLine(Jar2 + " Jars of Jelly\n");


    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit. ");
    string yesno = Console.ReadLine().ToLower();
   if (yesno == "y" || yesno == "yes")
    { continue; }
    else 
    { Console.WriteLine("thank you and have a great day");
      break;}
}


