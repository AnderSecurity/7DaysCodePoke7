using Pokemon7DaysCode.Poke7.Models;

namespace Pokemon7DaysCode.Poke7.Menus
{
    internal class MainMenu : Menu
    {
        public char ChoosedOption { get; set; }
        public MainMenu()
        {
            this.Title = @"
██████╗░░█████╗░██╗░░██╗███████╗███████╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝╚════██║
██████╔╝██║░░██║█████═╝░█████╗░░░░░░██╔╝
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░░░░██╔╝░
██║░░░░░╚█████╔╝██║░╚██╗███████╗░░██╔╝░░
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝░░╚═╝░░░
            ";
            this.SubTitle = "Seu poke7 de estimação!";
        }
        public MainMenu(string title, string subTitle) : base(title, subTitle)
        {
        }

        public MainMenu(User user)
        {
            this.Title = @"
██████╗░░█████╗░██╗░░██╗███████╗███████╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝╚════██║
██████╔╝██║░░██║█████═╝░█████╗░░░░░░██╔╝
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░░░░██╔╝░
██║░░░░░╚█████╔╝██║░╚██╗███████╗░░██╔╝░░
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝░░╚═╝░░░
            ";
            this.SubTitle = "Seu poke7 de estimação!";
            this.UserLogged = user;
        }

        public override void MenuFunc()
        {
            Console.WriteLine();
            Console.WriteLine($"Bem vindo, {this.UserLogged!.Name}.");
            Console.WriteLine("\nSelecione uma das opções abaixo: ");
            Console.WriteLine("=============================");
            Console.WriteLine("1) Adotar um poke7");
            Console.WriteLine("2) Ver meus mascotes");
            Console.WriteLine("3) Sair");
            Console.WriteLine("=============================");

            Console.Write("\nNúmero da opção desejada: ");
            this.ChoosedOption = char.Parse(Console.ReadLine()!);
        }
    }
}
