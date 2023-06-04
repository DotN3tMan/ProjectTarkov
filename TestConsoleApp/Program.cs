using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using Models.Items.Firearm;

var jsonStr = File.ReadAllText("firearm.json");

var obj = JsonSerializer.Deserialize<Firearm>(jsonStr);

Console.ReadKey();