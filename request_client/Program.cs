// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

HttpClient client = new HttpClient();
var response = client.Send(new HttpRequestMessage(HttpMethod.Get, "https://www.google.com"));
using var reader = new StreamReader(response.Content.ReadAsStream());

Console.Write(reader.ReadToEnd());
