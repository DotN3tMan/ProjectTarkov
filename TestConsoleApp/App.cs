using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
using Models;
using Models.TarkovGraphQlModels;

namespace TestConsoleApp
{
    internal class App
    {
        public async Task<WeaponDb> RunAsync(string query)
        {
            var data = new Dictionary<string, string>()
            {
                {"query", query}
            };

            using (var httpClient = new HttpClient())
            {
                //Http response message
                var httpResponse = await httpClient.PostAsJsonAsync("https://api.tarkov.dev/graphql", data);

                //Response content
                var responseContent = await httpResponse.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<WeaponDb>(responseContent);
            }
        }
    }
}
