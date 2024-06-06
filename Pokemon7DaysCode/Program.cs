using Pokemon7DaysCode.Poke7.Controller;
using Pokemon7DaysCode.Poke7.Menus;
using Pokemon7DaysCode.Poke7.Models;

try
{
    MainMenu mainMenu = new();
    mainMenu.ShowMenu();

    Console.Write("Digite seu nome: ");
    string name = Console.ReadLine()!;
    User user = new(name);

    Poke7Controller poke7Controller = new(user);
    poke7Controller.Start();
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro: " + e.Message);
}