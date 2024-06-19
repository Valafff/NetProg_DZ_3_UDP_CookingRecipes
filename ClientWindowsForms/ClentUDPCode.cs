using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerUDP
{

	public class ClientUDP
	{
		public delegate void DataFromServer(object obj);
		public event DataFromServer DataFromServerEvent;
		public string ip = "127.0.0.1";
		public int ReceiverPort = 2222;
		const int bufferSize = 1024;

		//Установление конечной точки
		public IPEndPoint ReceivingEndPont;
		public IPEndPoint ServerEndPont;
		public UdpClient udpRequestSender;
		byte[] buffer = new byte[bufferSize];

        public ClientUDP()
        {
			

			ReceivingEndPont = new IPEndPoint(IPAddress.Parse(ip), ReceiverPort);
			ServerEndPont = new IPEndPoint(IPAddress.Parse(ip), ReceiverPort);
			udpRequestSender = new UdpClient();
		}

        //Отправитель данных со временем
        public void SendRequest(string _request)
		{
			try
			{
					buffer = Encoding.UTF8.GetBytes(_request);
					udpRequestSender.Send(buffer, buffer.Length);			
			}
			catch (Exception) 
			{
				Console.WriteLine("Соединение не установлено");
			}
		}

		public async void ReciveFromServer()
		{
			try
			{
			
				byte[] receivedResult = udpRequestSender.Receive(ref ServerEndPont);
				string receivedMessage = Encoding.UTF8.GetString(receivedResult);
				//Сначала сервер отправляет сколько рецептов нашел
				int iterations = Convert.ToInt32(receivedMessage);
				if (iterations == 0)
				{
					//await Console.Out.WriteLineAsync("Рецепты не найдены");
					DataFromServerEvent((object)"Рецепты не найдены");
				}
				for (int i = 0; i < iterations; i++)
				{
					//udpRequestSender.Client.ReceiveBufferSize = 

					receivedResult = udpRequestSender.Receive(ref ServerEndPont);
					receivedMessage = Encoding.UTF8.GetString(receivedResult);
					Console.WriteLine(receivedMessage);
					DataFromServerEvent((object)receivedMessage);
				}


			}
			catch (Exception)
			{
				Console.WriteLine("Соединение не установлено");
			}
		}

		public async Task StartClientToRecive()
		{
			//Установление конечной точки
			IPEndPoint ReceivingEndPont = new IPEndPoint(IPAddress.Parse(ip), ReceiverPort);
			UdpClient udpRequestSender = new UdpClient();
			udpRequestSender.Connect(ReceivingEndPont);
			byte[] buffer = new byte[bufferSize];

			Console.WriteLine("Нажмите любую кнопку для начала отправки данных");
			Console.ReadKey();
			try
			{
				while (true)
				{
					Console.WriteLine("Введите название ингредиента или ключевое слово");
					string request = Console.ReadLine();
					buffer = Encoding.UTF8.GetBytes(request);
					await Console.Out.WriteLineAsync("Пытаюсь отправить запрос...");
					await udpRequestSender.SendAsync(buffer, buffer.Length);

					//Получение данных от получателей времени
					UdpReceiveResult receivedResult = await udpRequestSender.ReceiveAsync();
					string receivedMessage = Encoding.UTF8.GetString(receivedResult.Buffer);

					int iterations = Convert.ToInt32(receivedMessage);
					if (iterations == 0)
					{
						await Console.Out.WriteLineAsync("Рецепты не найдены");
					}
					for (int i = 0; i < iterations; i++)
					{
						receivedResult = await udpRequestSender.ReceiveAsync();
						receivedMessage = Encoding.UTF8.GetString(receivedResult.Buffer);
						Console.WriteLine($"\nСообщение от получателя:\n {receivedMessage}");
					}

					Console.WriteLine($"Сообщение от сервера: {receivedMessage}");
				}
			}
			catch
			{
				await Console.Out.WriteLineAsync("Соединение не установлено");
			}
			finally
			{
				udpRequestSender.Close();
			}
		}


	}
}
