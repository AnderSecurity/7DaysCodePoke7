using Pokemon7DaysCode.Poke7.Models;

namespace Pokemon7DaysCode.Poke7.View
{
    internal class Poke7View
    {
        public void InitialProgram()
        {
            try
            {
                string title = @"
██████╗░░█████╗░██╗░░██╗███████╗███████╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝╚════██║
██████╔╝██║░░██║█████═╝░█████╗░░░░░░██╔╝
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░░░░██╔╝░
██║░░░░░╚█████╔╝██║░╚██╗███████╗░░██╔╝░░
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝░░╚═╝░░░
            ";
                Console.WriteLine(title);

                Console.Write("\nDigite seu nome: ");               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }

        public int ChooseOption()
        {
            Console.Write("\nNúmero da opção desejada: ");
            return int.Parse(Console.ReadLine()!);
        }

        public void MainMenu(User user)
        {
            try
            {
                string title = @"
██████╗░░█████╗░██╗░░██╗███████╗███████╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝╚════██║
██████╔╝██║░░██║█████═╝░█████╗░░░░░░██╔╝
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░░░░██╔╝░
██║░░░░░╚█████╔╝██║░╚██╗███████╗░░██╔╝░░
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝░░╚═╝░░░
            ";
                Console.WriteLine(title);

                Console.WriteLine();
                Console.WriteLine($"Bem vindo, {user.Name}.");
                Console.WriteLine("\nSelecione uma das opções abaixo: ");
                Console.WriteLine("=============================");
                Console.WriteLine("1) Adotar um poke7");
                Console.WriteLine("2) Meus mascotes");
                Console.WriteLine("3) Sair");
                Console.WriteLine("=============================");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }           
        }

        public void ChoosePoke7Menu(User user, List<Poke7Data> poke7Avaible)
        {
            try
            {
                string title = @"
███████████████████████████████████████████████████████████████████████████████
██▀▄─██▄─▄▄▀█─▄▄─█─▄▄▄─██▀▄─██─▄▄─███▄─▄▄▀█▄─▄▄─███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
██─▀─███─██─█─██─█─███▀██─▀─██─██─████─██─██─▄█▀████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
";
                Console.WriteLine(title);

                Console.WriteLine("=============================");
                Console.WriteLine($"{user.Name}, selecione um poke7:");
                Console.WriteLine("=============================");

                for(int i = 0; i < poke7Avaible.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {poke7Avaible[i].Name}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }

        public void Poke7ActionsMenu(User user, Models.Poke7 poke7)
        {
            string title = @"
████████████████████████████████████████████████████████████████████████████████████████
██▀▄─██─▄▄▄─█─▄▄─█▄─▄▄─█─▄▄▄▄███─▄▄▄─█─▄▄─█▄─▀█▀─▄███─▄▄─███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
██─▀─██─███▀█─██─██─▄█▀█▄▄▄▄─███─███▀█─██─██─█▄█─████─██─████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▀▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
";
            Console.WriteLine(title);

            Console.WriteLine("===================");
            Console.WriteLine($"{user.Name}, o que deseja fazer?");
            Console.WriteLine("===================");

            Console.WriteLine($"1) Saber mais sobre o {poke7.Name}");
            Console.WriteLine($"2) Adotar o {poke7.Name}");
            Console.WriteLine($"3) Voltar");
        }

        public void MyPoke7Menu(User user)
        {
            string title = @"
██████████████████████████████████████████████████████████████████
█▄─▀█▀─▄█▄─▄▄─█▄─██─▄█─▄▄▄▄███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█░█─▄▄▄▄█
██─█▄█─███─▄█▀██─██─██▄▄▄▄─████─▄▄▄█─██─██─▄▀███─▄█▀███░██▄█▄▄▄▄─█
▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀▀▀▄▄▄▄▄▀
";
            Console.WriteLine(title);

            if (!user.Poke7List!.Any())
            {
                Console.WriteLine("Você não possui nenhum poke7 ainda :(");

                Console.WriteLine();
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Mascote selecionado: " + (user.SelectedPoke7 is not null ? user.SelectedPoke7.Name:"Nenhum ainda :("));
                Console.WriteLine("=======================");

                foreach (var poke7 in user.Poke7List!.ToList())
                {
                    Console.WriteLine();
                    Console.WriteLine($"{poke7}");
                    poke7.ShowStatus();
                    Console.WriteLine("=======================");
                }

                Console.WriteLine("\nO que deseja fazer?\n");
                Console.WriteLine("1) Selecionar um Poke7");
                Console.WriteLine("2) Interagir com meu Poke7 selecionado");
                Console.WriteLine("3) Voltar");
            }           
        }

        public void ChooseMyPoke7(User user)
        {           
            Console.WriteLine(@"
██████████████████████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█▄─▄▄─█▄─▄███▄─▄▄─█─▄▄▄─█▄─▄█─▄▄─█▄─▀█▄─▄██▀▄─██▄─▄▄▀███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
█▄▄▄▄─██─▄█▀██─██▀██─▄█▀█─███▀██─██─██─██─█▄▀─███─▀─███─▄─▄████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
");
            Console.WriteLine();

            for (int i = 0; i<user.Poke7List!.Count; i++)
            {
                Console.WriteLine($"{i+1}) {user.Poke7List[i].Name}");
            }
            Console.WriteLine("\nQual pokemon você deseja escolher?");
        }

        public void ActWithMySelectedPoke7(User user)
        {
            Console.WriteLine(@"
█████████████████████████████████████████▀███████████
█▄─▄█▄─▀█▄─▄█─▄─▄─█▄─▄▄─█▄─▄▄▀██▀▄─██─▄▄▄▄█▄─▄█▄─▄▄▀█
██─███─█▄▀─████─████─▄█▀██─▄─▄██─▀─██─██▄─██─███─▄─▄█
▀▄▄▄▀▄▄▄▀▀▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▀▄▄▀
");
            Console.WriteLine();

            Console.WriteLine("===================");
            Console.WriteLine($"{user.Name}, o que deseja fazer?");
            Console.WriteLine("===================");

            Console.WriteLine($"1) Brincar com o {user.SelectedPoke7!.Name}");
            Console.WriteLine($"2) Alimentar o {user.SelectedPoke7!.Name}");
            Console.WriteLine($"3) Fazer o {user.SelectedPoke7!.Name} dormir");
            Console.WriteLine($"4) Voltar");
        }

        public void AfterPlay(User user)
        {
            Console.WriteLine(@"
████████████████████████████████████████████████████████
█▄─▄─▀█▄─▄▄▀█▄─▄█▄─▀█▄─▄█─▄▄▄─██▀▄─██▄─▀█▄─▄█▄─▄▄▀█─▄▄─█
██─▄─▀██─▄─▄██─███─█▄▀─██─███▀██─▀─███─█▄▀─███─██─█─██─█
▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀
");
            Console.WriteLine($"Brincando com o {user.SelectedPoke7!.Name}...");
            Thread.Sleep(3000);

            Console.WriteLine($"\nEbaaa! Agora o {user.SelectedPoke7.Name} está assim:");
            user.SelectedPoke7.ShowStatus();

            Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
        }

        public void AfterEat(User user)
        {
            Console.WriteLine(@"
██████████████████████████████████████████████████████████████████████
██▀▄─██▄─▄███▄─▄█▄─▀█▀─▄█▄─▄▄─█▄─▀█▄─▄█─▄─▄─██▀▄─██▄─▀█▄─▄█▄─▄▄▀█─▄▄─█
██─▀─███─██▀██─███─█▄█─███─▄█▀██─█▄▀─████─████─▀─███─█▄▀─███─██─█─██─█
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀
");
            Console.WriteLine($"Alimentando o {user.SelectedPoke7!.Name}...");
            Thread.Sleep(3000);

            Console.WriteLine($"\nEbaaa! Agora o {user.SelectedPoke7.Name} está assim:");
            user.SelectedPoke7.ShowStatus();

            Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
        }

        public void AfterSleep(User user)
        {
            Console.WriteLine(@"
█████████████████████████████████████████████████████████████
█▄─▄█▄─▀█▄─▄█▄─▄▄▀█─▄▄─███▄─▄▄▀█─▄▄─█▄─▄▄▀█▄─▀█▀─▄█▄─▄█▄─▄▄▀█
██─███─█▄▀─███─██─█─██─████─██─█─██─██─▄─▄██─█▄█─███─███─▄─▄█
▀▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▀▄▄▄▀▄▄▄▀▄▄▀▄▄▀
");
            Console.WriteLine($"Colocando o {user.SelectedPoke7!.Name} para dormir...");
            Thread.Sleep(3000);

            Console.WriteLine($"\nEbaaa! Agora o {user.SelectedPoke7.Name} está assim:");
            user.SelectedPoke7.ShowStatus();

            Console.WriteLine("\nPressione uma tecla para continuar...");
            Console.ReadKey();
        }

        public void ShowPoke7(Models.Poke7 poke7)
        {
            Console.Clear();
            Console.WriteLine(@"
█████████████████████████████████████████████████████████████████████████████████████████████
█▄─▀█▀─▄██▀▄─██▄─▄█─▄▄▄▄███─▄▄▄▄█─▄▄─█▄─▄─▀█▄─▄▄▀█▄─▄▄─███─▄▄─███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
██─█▄█─███─▀─███─██▄▄▄▄─███▄▄▄▄─█─██─██─▄─▀██─▄─▄██─▄█▀███─██─████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▄▀▄▄▄▀▄▄▀▄▄▀▄▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
");
            Console.WriteLine("================");
            Console.WriteLine(poke7);
            Console.WriteLine("================");

            Console.WriteLine("\nPressione uma tecla para voltar...");
            Console.ReadKey();
        }

        public void AdoptPoke7(User user, Models.Poke7 poke7)
        {
            string title = @"
██████████████████████████████████████████████████████████████████
██▀▄─██▄─▄▄▀█─▄▄─█─▄─▄─██▀▄─██▄─▄▄▀███▄─▄▄─█─▄▄─█▄─█─▄█▄─▄▄─█▄▄▄░█
██─▀─███─██─█─██─███─████─▀─███─▄─▄████─▄▄▄█─██─██─▄▀███─▄█▀███░██
▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄██▀
";
            Console.WriteLine(title);
            Console.WriteLine($"{user.Name}, o poke7 {poke7!.Name} foi adotado com sucesso!");
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
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
