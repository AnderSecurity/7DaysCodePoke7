using Microsoft.VisualBasic.FileIO;
using Pokemon7DaysCode.Poke7.Models;
using Pokemon7DaysCode.Poke7.Service;
using Pokemon7DaysCode.Poke7.View;
using RestSharp;

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
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
                Thread.Sleep(5000);
            }

            int choosed = 0;

            while (true)
            {
                try
                {
                    Console.Clear();
                    View!.MainMenu(this.User!);
                    choosed = View.ChooseOption();

                    switch (choosed)
                    {
                        case 1:
                            try
                            {
                                Console.Clear();
                                View.ChoosePoke7Menu(this.User!, Poke7Avaible!);
                                int choosedAPIOption = View.ChooseOption();

                                if (choosedAPIOption > 20)
                                {
                                    throw new Exception("Opção Inválida!");
                                }
                                else
                                {
                                    var myPoke7 = Service!.GetPoke7ByAPIOption(choosedAPIOption);

                                    if (myPoke7.Name!.Equals(""))
                                    {
                                        Console.WriteLine("Não foi possível encontrar o Poke7! Pressione uma tecla para voltar ao menu principal...");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        bool goToMainMenu = false;

                                        while (!goToMainMenu)
                                        {
                                            Console.Clear();
                                            View.Poke7ActionsMenu(this.User!, myPoke7!);
                                            int choosedOption = View.ChooseOption();

                                            switch (choosedOption)
                                            {
                                                case 1:
                                                    Console.Clear();
                                                    View.ShowPoke7(myPoke7!);
                                                    break;

                                                case 2:
                                                    Console.Clear();
                                                    this.User!.poke7List.Add(myPoke7!);
                                                    View.AdoptPoke7(this.User, myPoke7!);
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
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"\nOcorreu um erro: {ex.Message}");
                                Console.WriteLine("Pressione uma tecla para voltar ao menu principal...");
                                Console.ReadKey();
                            }

                            break;

                        case 2:
                            Console.Clear();
                            View.MyPoke7Menu(this.User!);
                            break;

                        case 3:
                            Console.WriteLine("Saindo da aplicação...");
                            return;

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
            }
        }
    }
}
