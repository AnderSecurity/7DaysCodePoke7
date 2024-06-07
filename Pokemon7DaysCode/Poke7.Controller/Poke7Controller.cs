using Microsoft.VisualBasic.FileIO;
using Pokemon7DaysCode.Poke7.Models;
using Pokemon7DaysCode.Poke7.Service;
using Pokemon7DaysCode.Poke7.View;
using RestSharp;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;


namespace Pokemon7DaysCode.Poke7.Controller
{
    internal class Poke7Controller
    {
        private User? User { get; set; }
        private Poke7View? View { get; set; }
        private Poke7APIService? Service { get; set; }
        private List<Poke7Data>? Poke7Avaible { get; set; }

        public Poke7Controller()
        {
            View = new Poke7View();
            Service = new Poke7APIService();
            Poke7Avaible = Service.GetAllPoke7();
        }

        public Poke7Controller(User user) : this()
        {
            this.User = user;
        }

        public void Start()
        {
            this.InitializeUser();
            while (true)
            {
                try
                {
                    int choice = this.GetChoiceMainMenu();
                    this.MainMenuChoosedOption(choice);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato Inválido!");
                    Thread.Sleep(2000);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e.Message);
                    Thread.Sleep(2000);
                }
            }
        }

        private void InitializeUser()
        {
            try
            {
                Console.Clear();
                View!.InitialProgram();
                this.User = new(Console.ReadLine()!);

                if (this.User is null)
                {
                    throw new Exception("Não é possível começar um jogo sem usuário logado!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao inicializar o usuário: " + ex.Message);
                Thread.Sleep(5000);
            }
        }

        private int GetChoiceMainMenu()
        {
            Console.Clear();
            View!.MainMenu(this.User!);
            return View.ChooseOption();
        }

        private void MainMenuChoosedOption(int choice)
        {
            switch (choice)
            {
                case 1:
                    this.ShowPoke7Menu();
                    break;

                case 2:
                    this.ShowMyPoke7();
                    break;

                case 3:
                    Console.WriteLine("Saindo da aplicação...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    Thread.Sleep(2000);
                    break;
            }            
        }

        private void ShowPoke7Menu()
        {
            var myPoke7 = this.ChoosePoke7ByAPI();
            bool goToMainMenu = false;

            if(myPoke7 is null) {
                goToMainMenu = true;
            }

            while (!goToMainMenu)
            {
                int choice = this.ShowPoke7ActionsMenu(myPoke7!);

                switch (choice)
                {
                    case 1:
                        this.ShowAboutPoke7(myPoke7!);
                        break;

                    case 2:
                        this.AdoptPoke7(myPoke7!);
                        goToMainMenu = true;
                        break;

                    case 3:
                        goToMainMenu = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente...");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }

        private Models.Poke7? ChoosePoke7ByAPI()
        {
            Models.Poke7 myPoke7 = new();

            try
            {                
                Console.Clear();
                View!.ChoosePoke7Menu(this.User!, Poke7Avaible!);
                int choosedAPIOption = View.ChooseOption();

                if (choosedAPIOption > 20)
                {
                    throw new Exception("\nOpção Inválida!");
                }

                myPoke7 = Service!.GetPoke7ByAPIOption(choosedAPIOption);

                if (string.IsNullOrEmpty(myPoke7.Name!))
                {
                    throw new Exception("\nNão foi possível encontrar o Poke7!");
                }

                return myPoke7;
            }
            catch(FormatException)
            {
                Console.WriteLine("\nDigite apenas números de 0 a 20!");
                Console.WriteLine("\nPressione uma tecla para voltar ao menu principal...");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPressione uma tecla para voltar ao menu principal...");
                Console.ReadKey();
            }

            return null;
        }

        private void ShowMyPoke7()
        {
            Console.Clear();
            View!.MyPoke7Menu(this.User!);
        }

        private int ShowPoke7ActionsMenu(Models.Poke7 myPoke7)
        {
            Console.Clear();
            View!.Poke7ActionsMenu(this.User!, myPoke7!);
            return View.ChooseOption();
        }

        private void ShowAboutPoke7(Models.Poke7 myPoke7)
        {
            Console.Clear();
            View!.ShowPoke7(myPoke7!);
        }

        private void AdoptPoke7(Models.Poke7 myPoke7)
        {
            Console.Clear();
            this.User!.poke7List.Add(myPoke7!);
            View!.AdoptPoke7(this.User, myPoke7!);
        }
    }
}
