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
                Console.WriteLine("2) Ver meus mascotes");
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

            if (!user.poke7List.Any())
            {
                Console.WriteLine("Você não possui nenhum poke7 ainda :(");
            }
            else
            {
                foreach (var poke7 in user.poke7List.ToList())
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine($"{poke7}");
                    Console.WriteLine("=======================");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar...");
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
