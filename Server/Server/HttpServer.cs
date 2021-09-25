using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Server
{
	class HttpServer
	{
		HttpListener _httpListener;
		
		public HttpServer()
		{
			_httpListener = new HttpListener();
			_httpListener.Prefixes.Add("http://localhost:8888/connection/");
			_httpListener.Start();

			Console.WriteLine("Waiting for a connection...");

			HttpListenerContext context = _httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse response = context.Response;

			string responseStr = "[SERVER] => Hello, i'm а server";
			byte[] buffer = Encoding.UTF8.GetBytes(responseStr);
			Stream output = response.OutputStream;
			output.Write(buffer, 0, buffer.Length);
			output.Close();

			_httpListener.Stop();
			Console.WriteLine("Connection processing is complete");
			Console.ReadKey();
		}
	}
}
