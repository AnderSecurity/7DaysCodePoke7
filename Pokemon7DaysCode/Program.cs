using Pokemon7DaysCode.Poke7.Menus;
using Pokemon7DaysCode.Poke7.Models;

MainMenu mainMenu = new();
char choosed = '0';

try
{
    mainMenu.ShowMenu();

    Console.Write("Digite seu nome: ");
    string name = Console.ReadLine()!;
    User user = new(name);

    mainMenu.UserLogged = user;

    while (choosed != '3')
    {
        try
        {
            mainMenu.ShowMenu();
            mainMenu.MenuFunc();
            choosed = mainMenu.ChoosedOption;

            switch (choosed)
            {
                case '1':
                    ChoosePoke7Menu choosePoke7Menu = new(user);
                    choosePoke7Menu.ShowMenu();
                    choosePoke7Menu.MenuFunc();
                    break;

                case '2':
                    MyPoke7Menu myPoke7Menu = new(user);
                    myPoke7Menu.ShowMenu();
                    myPoke7Menu.MenuFunc();
                    break;

                case '3':
                    Console.WriteLine("Saindo da aplicação...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato Inválido!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro: " + e.Message);
        }
        finally
        {
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro: " + e.Message);
}