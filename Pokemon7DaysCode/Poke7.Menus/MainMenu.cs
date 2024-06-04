using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon7DaysCode.Menus
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

        public override void ShowMenu()
        {
            base.ShowMenu();
        }

        public override void MenuFunc()
        {
            Console.WriteLine();
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("=============================");
            Console.WriteLine("1) Selecionar um poke7");
            Console.WriteLine("2) Sair");
            Console.WriteLine("=============================");

            Console.Write("\nNúmero da opção desejada: ");
            this.ChoosedOption = char.Parse(Console.ReadLine()!);
        }
    }
}
