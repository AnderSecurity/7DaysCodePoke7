using Pokemon7DaysCode.Poke7.Menus;
using Pokemon7DaysCode.Poke7.Models;
using RestSharp;
using System.Text.Json;

namespace Pokemon7DaysCode.Poke7.Menus
{
    internal class MyPoke7Menu : Menu
    {

        public MyPoke7Menu()
        {
            this.Title = @"
██████████████████████████████████████████████████████████████████
█▄─▀█▀─▄█▄─▄▄─█▄─██─▄█─▄▄▄▄███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█░█─▄▄▄▄█
██─█▄█─███─▄█▀██─██─██▄▄▄▄─████─▄▄▄█─██─██─▄▀███─▄█▀███░██▄█▄▄▄▄─█
▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀▀▀▄▄▄▄▄▀
";
        }

        public MyPoke7Menu(User userLogged) : base(userLogged)
        {
            this.Title = @"
██████████████████████████████████████████████████████████████████
█▄─▀█▀─▄█▄─▄▄─█▄─██─▄█─▄▄▄▄███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█░█─▄▄▄▄█
██─█▄█─███─▄█▀██─██─██▄▄▄▄─████─▄▄▄█─██─██─▄▀███─▄█▀███░██▄█▄▄▄▄─█
▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀▀▀▄▄▄▄▄▀
";
        }

        public MyPoke7Menu(string title, string subTitle) : base(title, subTitle) { }

        public override void MenuFunc()
        {
            if (!this.UserLogged!.poke7List.Any())
            {
                Console.WriteLine("Você não possui nenhum poke7 ainda :(");
            }

            foreach (var poke7 in this.UserLogged!.poke7List.ToList())
            {
                Console.WriteLine("=======================");
                Console.WriteLine($"{poke7}");
                Console.WriteLine("=======================");
            }
        }
    }
}
