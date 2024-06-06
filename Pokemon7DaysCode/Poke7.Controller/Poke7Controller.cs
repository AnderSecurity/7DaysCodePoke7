using Pokemon7DaysCode.Poke7.Menus;
using Pokemon7DaysCode.Poke7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon7DaysCode.Poke7.Controller
{
    internal class Poke7Controller
    {
        public User? user { get; set; }

        public Poke7Controller() { }

        public Poke7Controller(User user)
        {
            this.user = user;
        }

        public void Start()
        {
            if(user is null)
            {
                throw new Exception("Não é possível começar um jogo sem usuário logado!");
            }

            MainMenu mainMenu = new(this.user!);
            char choosed = '0';

            while (choosed != '3')
            {
                try
                {
                    mainMenu.ShowMenu();
                    mainMenu.MenuFunc();
                    choosed = mainMenu.ChoosedOption;

                    switch (choosed)
                    {
                        case '1':
                            ChoosePoke7Menu choosePoke7Menu = new(user);
                            choosePoke7Menu.ShowMenu();
                            choosePoke7Menu.MenuFunc();
                            break;

                        case '2':
                            MyPoke7Menu myPoke7Menu = new(user);
                            myPoke7Menu.ShowMenu();
                            myPoke7Menu.MenuFunc();
                            break;

                        case '3':
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
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro: " + e.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Pressione uma tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
