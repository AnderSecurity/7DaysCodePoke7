using Pokemon7DaysCode.Poke7.Models;

namespace Pokemon7DaysCode.Poke7.Menus
{
    internal class Poke7ActionsMenu : Menu
    {
        Models.Poke7? Poke7;
        public Poke7ActionsMenu()
        {
            this.Title = @"
████████████████████████████████████████████████████████████████████████████████████████
██▀▄─██─▄▄▄─█─▄▄─█▄─▄▄─█─▄▄▄▄███─▄▄▄─█─▄▄─█▄─▀█▀─▄███─▄▄─███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
██─▀─██─███▀█─██─██─▄█▀█▄▄▄▄─███─███▀█─██─██─█▄█─████─██─████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
";
        }

        public Poke7ActionsMenu(string title, string subtitle) : base(title, subtitle)
        {
            this.Title = @"
████████████████████████████████████████████████████████████████████████████████████████
██▀▄─██─▄▄▄─█─▄▄─█▄─▄▄─█─▄▄▄▄███─▄▄▄─█─▄▄─█▄─▀█▀─▄███─▄▄─███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
██─▀─██─███▀█─██─██─▄█▀█▄▄▄▄─███─███▀█─██─██─█▄█─████─██─████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
";
        }
        public Poke7ActionsMenu(User loggedUser, Models.Poke7 poke7) : base(loggedUser)
        {
            this.Poke7 = poke7;
            this.Title = @"
████████████████████████████████████████████████████████████████████████████████████████
██▀▄─██─▄▄▄─█─▄▄─█▄─▄▄─█─▄▄▄▄███─▄▄▄─█─▄▄─█▄─▀█▀─▄███─▄▄─███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
██─▀─██─███▀█─██─██─▄█▀█▄▄▄▄─███─███▀█─██─██─█▄█─████─██─████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
";
        }

        public override void MenuFunc()
        {
            try
            {
                this.ShowMenu();
                Console.WriteLine("===================");
                Console.WriteLine($"{this.UserLogged!.Name}, o que deseja fazer?");
                Console.WriteLine("===================");

                Console.WriteLine($"1) Saber mais sobre o {this.Poke7!.Name}");
                Console.WriteLine($"2) Adotar o {this.Poke7!.Name}");
                Console.WriteLine($"3) Voltar");

                Console.Write("\nNúmero da opção: ");
                char choosed = Convert.ToChar(Console.ReadLine()!);

                switch (choosed)
                {
                    case '1':
                        this.ShowMenu();
                        this.showPoke7();
                        break;

                    case '2':
                        this.ShowMenu();
                        this.adoptPoke7();
                        break;

                    case '3':
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Voltando ao menu principal...");
                        Thread.Sleep(3000);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void showPoke7()
        {
            Console.Clear();
            Console.WriteLine(@"
█████████████████████████████████████████████████████████████████████████████████████████████
█▄─▀█▀─▄██▀▄─██▄─▄█─▄▄▄▄███─▄▄▄▄█─▄▄─█▄─▄─▀█▄─▄▄▀█▄─▄▄─███─▄▄─███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
██─█▄█─███─▀─███─██▄▄▄▄─███▄▄▄▄─█─██─██─▄─▀██─▄─▄██─▄█▀███─██─████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▄▀▄▄▄▀▄▄▀▄▄▀▄▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
");
            Console.WriteLine("================");
            Console.WriteLine(this.Poke7);
            Console.WriteLine("================");

            Console.WriteLine("\nPressione uma tecla para voltar...");
            Console.ReadKey();
            this.MenuFunc();
        }

        private void adoptPoke7()
        {
            this.UserLogged!.poke7List.Add(this.Poke7!);
            Console.WriteLine($"{this.UserLogged.Name}, o poke7 {Poke7!.Name} foi adotado com sucesso!");
            Console.WriteLine("Chocandooo...");
            Console.WriteLine(@"
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░███████░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░█████████░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░████████████░░░░░░░░░░░░░░░░
░░░░░░░░░░░░█████████████░░░░░░░░░░░░░░░
░░░░░░░░░░░███████████████░░░░░░░░░░░░░░
░░░░░░░░░░░███████████████░░░░░░░░░░░░░░
░░░░░░░░░░░███████████████░░░░░░░░░░░░░░
░░░░░░░░░░░░█████████████░░░░░░░░░░░░░░░
░░░░░░░░░░░░████████████░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░████████░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
");
        }
    }
}
