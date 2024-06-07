using Microsoft.VisualBasic.FileIO;
using Pokemon7DaysCode.Poke7.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pokemon7DaysCode.Poke7.Service
{
    internal class Poke7APIService
    {
        public Models.Poke7 GetPoke7ByAPI(char apiOption)
        {
            Models.Poke7 myPoke7 = new();

            try
            {
                var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{apiOption}");
                RestRequest request = new("", Method.Get);
                var response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    myPoke7 = JsonSerializer.Deserialize<Poke7.Models.Poke7>(response.Content!)!;                   
                }
                else
                {
                    Console.WriteLine(response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return myPoke7;
        }
    }
}
