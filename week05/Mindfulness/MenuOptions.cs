using System.Security.Cryptography.X509Certificates;

class MenuOptions
{
    private string _option;
    public void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Lisitng Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from menu by number: ");
        _option = Console.ReadLine();
    }
    public string GetOption()
    {
        return _option;
    }
    public void NumberError()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid number! Please try again...");
        Thread.Sleep(2000);
        Console.ResetColor();
    }
}