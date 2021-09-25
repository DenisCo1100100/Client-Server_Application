using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Server
{
	class Program
	{
		static async Task Main()
		{
			var httpServer = new HttpServer();

			var client = new HttpClient();
			Console.WriteLine("Connection client...");
			var result = await client.GetAsync("http://localhost:8888/connection/");

			Console.WriteLine(result);
		}
	}
}
