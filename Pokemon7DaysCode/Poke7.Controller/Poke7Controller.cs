using Pokemon7DaysCode.Poke7.Models;
using Pokemon7DaysCode.Poke7.Service;
using Pokemon7DaysCode.Poke7.View;
using RestSharp;

using System.Text.Json;


namespace Pokemon7DaysCode.Poke7.Controller
{
    internal class Poke7Controller
    {
        private User? user { get; set; }
        private Poke7View? view { get; set; }
        private Poke7APIService service { get; set; }

        public Poke7Controller()
        {
            view = new Poke7View();
            service = new Poke7APIService();
        }

        public Poke7Controller(User user) : this()
        {
            this.user = user;
        }

        public void Start()
        {
            try
            {
                Console.Clear();
                view!.InitialProgram();
                this.user = new(Console.ReadLine()!);

                if (this.user is null)
                {
                    throw new Exception("Não é possível começar um jogo sem usuário logado!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
                Thread.Sleep(5000);
            }
            
            char choosed = '0';

            while (true)
            {
                try
                {
                    Console.Clear();
                    view!.MainMenu(this.user!);
                    choosed = view.ChooseOption();
                    
                    switch (choosed)
                    {
                        case '1':
                            Console.Clear();
                            view.ChoosePoke7Menu(this.user!);
                            char choosedOptionCase1 = view.ChooseOption();
                            char apiOption = '0';

                            switch (choosedOptionCase1)
                            {
                                case '1':
                                    apiOption = '1';
                                    break;

                                case '2':
                                    apiOption = '4';
                                    break;

                                case '3':
                                    apiOption = '7';
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }

                            if (apiOption != '0')
                            {
                                var myPoke7 = service.GetPoke7ByAPI(apiOption);

                                try
                                {
                                    bool goToMainMenu = false;

                                    while (!goToMainMenu)
                                    {
                                        Console.Clear();
                                        view.Poke7ActionsMenu(this.user!, myPoke7!);
                                        char choosedOption = view.ChooseOption();

                                        switch (choosedOption)
                                        {
                                            case '1':
                                                Console.Clear();
                                                view.ShowPoke7(myPoke7!);
                                                break;

                                            case '2':
                                                Console.Clear();
                                                this.user!.poke7List.Add(myPoke7!);
                                                view.AdoptPoke7(this.user, myPoke7!);
                                                goToMainMenu = true;
                                                break;

                                            case '3':
                                                goToMainMenu = true;
                                                break;

                                            default:
                                                Console.WriteLine("Opção inválida! Tente novamente...");
                                                Thread.Sleep(2000);
                                                break;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                                }
                            }
                            break;

                        case '2':
                            Console.Clear();
                            view.MyPoke7Menu(this.user!);
                            break;

                        case '3':
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
