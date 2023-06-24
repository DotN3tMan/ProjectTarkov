using Models.TarkovGraphQlModels;
using System.IO;
using TestConsoleApp;

var app = new App();

WeaponDb t = await app.RunAsync(File.ReadAllText("WeaponDb.graphQl"));

Console.WriteLine("OK");