using Pokemon7DaysCode.Menus;

MainMenu mainMenu = new();
ChoosePoke7Menu choosePoke7Menu = new();
char resposta = '0';

while (resposta != '2')
{
    try
    {
        mainMenu.ShowMenu();
        mainMenu.MenuFunc();
        resposta = mainMenu.ChoosedOption;

        switch (resposta)
        {
            case '1':
                choosePoke7Menu.ShowMenu();
                choosePoke7Menu.MenuFunc();
                break;

            case '2':
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
    catch(Exception e)
    {
        Console.WriteLine("Ocorreu um erro: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Pressione uma tecla para continuar...");
        Console.ReadKey();
    }
}