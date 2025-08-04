using System;

class Program
{
    static void Main(string[] args)
    {
        MenuOptions menuOptions = new MenuOptions();
        menuOptions.ShowMenu();
        string option = menuOptions.GetOption();
        while (option != "4")
        {
            if (option == "1")
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                menuOptions.ShowMenu();
                option = menuOptions.GetOption();
            }
            else if (option == "2")
            {
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                menuOptions.ShowMenu();
                option = menuOptions.GetOption();
            }
            else if (option == "3")
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                listing.Run();
                menuOptions.ShowMenu();
                option = menuOptions.GetOption();
            }

            else
            {
                menuOptions.NumberError();
                menuOptions.ShowMenu();
                option = menuOptions.GetOption();
            }
        }
    }
}