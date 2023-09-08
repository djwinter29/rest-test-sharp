// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO.Enumeration;

Console.WriteLine("Hello, World!");
var filename = "json1.json";

var strings = File.ReadAllText(filename);
var data = (JObject)JsonConvert.DeserializeObject(strings);

Console.Write(data["response"]["TC_GetEncoderInputs"]);
//HttpClient client = new HttpClient();
//var response = client.Send(new HttpRequestMessage(HttpMethod.Get, "https://www.google.com"));
//using var reader = new StreamReader(response.Content.ReadAsStream());

//Console.Write(reader.ReadToEnd());
