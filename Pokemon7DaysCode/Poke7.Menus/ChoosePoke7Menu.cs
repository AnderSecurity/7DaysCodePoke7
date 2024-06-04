﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Pokemon7DaysCode.Menus
{
    internal class ChoosePoke7Menu : Menu
    {
        public ChoosePoke7Menu()
        {
            this.Title = @"
█▀▄▀█ █▀▀ █░█   █▀█ █▀█ █▄▀ █▀▀ ▀▀█
█░▀░█ ██▄ █▄█   █▀▀ █▄█ █░█ ██▄ ░░█
";
        }
        public ChoosePoke7Menu(string title, string subTitle) : base(title, subTitle)
        {
        }

        public override void ShowMenu()
        {
            base.ShowMenu();
        }

        public override void MenuFunc()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Selecione seu poke7:");
            Console.WriteLine("=============================");
            Console.WriteLine("1) Bulbasaur");
            Console.WriteLine("2) Charmander");
            Console.WriteLine("3) Squirtle");

            Console.Write("\nNúmero da Opção desejada: ");

            try
            {
                char optionChoosed = char.Parse(Console.ReadLine()!);
                char apiOption = '0';

                switch (optionChoosed)
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

                if (apiOption != 0)
                {
                    var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{apiOption}");
                    RestRequest request = new("", Method.Get);
                    var response = client.Execute(request);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        Console.WriteLine(response.Content);
                    }
                    else
                    {
                        Console.WriteLine(response.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}