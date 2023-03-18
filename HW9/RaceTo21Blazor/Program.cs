using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace RaceTo21Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //List<Player> players = new List<Player>();
            //CardTable cardTable = new CardTable();
            //Game game = new Game(cardTable, players);
            //Deck deck = new Deck();

            //deck.initializeGame(players);


            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();


        }
    }
}
