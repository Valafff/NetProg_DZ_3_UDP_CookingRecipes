using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServerUDP
{
	//Работает в режиме приема и передачи
	internal class ServerUDP
	{
		const int serverPort = 2222;
		const int MaxClientConnected = 5;
		const int MaxClientRequest = 5;
		const int ClientTimeLimit = 15;
		//const int PacketSize = 8194;

		UdpClient udpServer;
		IPEndPoint ClientEndPoint = null;
		List<Client> clientsPool = new List<Client>();
		List<Recipe> Recipes = new List<Recipe>();
		public class Client
		{
			public IPEndPoint EndPoint;
			public long connTime;
			public int RequesNumber;
			public DateTime shutDownTime;
			public bool shutdown = false;
		}

		public ServerUDP(List<Recipe> _Recipes)
		{
			Recipes = _Recipes;
		}
		~ServerUDP()
		{
			if (udpServer != null)
			{
				udpServer.Close();
			}
		}

		public void ServerStart()
		{
			while (true)
			{
				udpServer = new UdpClient(serverPort);

				try
				{
					while (true)
					{

						//!!!При получении первого пакета - узнаю конечную точку отправителя(клиента)	
						byte[] udpReceiveResult = udpServer.Receive(ref ClientEndPoint);
						CheckClient();
						Client tempCl = new Client() { EndPoint = ClientEndPoint, connTime = DateTime.UtcNow.Ticks };
						if (!clientsPool.Exists(f => f.EndPoint.Port == ClientEndPoint.Port) && clientsPool.Count < MaxClientConnected)
						{
							clientsPool.Add(tempCl);
							Console.WriteLine($"Количество подключенных пользователей: {clientsPool.Count}");
						}
						else
						{
							foreach (var item in clientsPool)
							{
								if (item.EndPoint.Port == ClientEndPoint.Port)
								{
									item.connTime = DateTime.UtcNow.Ticks;
								}
							}
						}

						if (clientsPool.Count <= MaxClientConnected && clientsPool.Exists(f => f.EndPoint.Port == ClientEndPoint.Port) && (clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port)).RequesNumber <= MaxClientRequest)
						{
							string res = Encoding.UTF8.GetString(udpReceiveResult);
							Console.WriteLine($"Конечная точка клиента:{ClientEndPoint.Address} {ClientEndPoint.Port}");

							//Зная конечную точку клиента отправляю ему ответ
							//udpServer.Send(udpReceiveResult, udpReceiveResult.Length, ClientEndPoint);
							RecipeRequest(res);

							foreach (var item in clientsPool)
							{
								if (item.EndPoint.Port == ClientEndPoint.Port)
								{
									item.RequesNumber++;
								}
							}
						}
						else if (clientsPool.Count <= MaxClientConnected && clientsPool.Exists(f => f.EndPoint.Port == ClientEndPoint.Port) && clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).RequesNumber > MaxClientRequest)
						{
							if (!clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).shutdown)
							{
								clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).shutDownTime = DateTime.UtcNow.AddHours(1);
								clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).shutdown = true;
							}
							string answer = $"Клиент {ClientEndPoint} превысил количество возможных запросов. Доступ будет разрешет через {clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).shutDownTime - DateTime.UtcNow}";
							udpServer.Send(Encoding.UTF8.GetBytes(answer), Encoding.UTF8.GetBytes(answer).Length, ClientEndPoint);
							Console.WriteLine(answer);
							if (clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).shutDownTime < DateTime.UtcNow)
							{
								clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).RequesNumber = 0;
							}
						}
						else
						{
							string answer = $"Сервер может обрабатывать запросы {MaxClientConnected} пользователей";
							udpServer.Send(Encoding.UTF8.GetBytes(answer), Encoding.UTF8.GetBytes(answer).Length, ClientEndPoint);
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine(answer);
							Console.ForegroundColor = ConsoleColor.White;
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine($"Исключение!");
				}
				finally
				{
					clientsPool.Clear();
					udpServer.Close();
					Console.WriteLine($"Переподключение!");
				}
			}

			void CheckClient()
			{
				long timeNow = DateTime.UtcNow.Ticks;
				var killList = new List<Client>();
				if (clientsPool.Count > 0)
				{
					foreach (var item in clientsPool)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine($"Клиент {item.EndPoint} делал запрос {(timeNow - item.connTime) / 10000000} секунд назад");
						Console.ForegroundColor = ConsoleColor.White;
						if (((timeNow - item.connTime) / 10000000) >= ClientTimeLimit)
						{
							//clientsPool.Remove(item);
							killList.Add(item);
						}
					}
					foreach (var item in killList)
					{
						if (clientsPool.Contains(item))
						{
							clientsPool.Remove(item);
						}
					}
					Console.WriteLine($"Текущее количество активных клиентов: {clientsPool.Count}");
				}
			}

			void RecipeRequest(string _keyword)
			{
				int counter = 0;
				List<byte[]> temp = new List<byte[]>();
				foreach (var item in Recipes)
				{
					if (item.Cooking.Contains(_keyword))
					{
						counter++;
						temp.Add(Encoding.UTF8.GetBytes(item.Cooking));
					}
				}
				var iterations = Encoding.UTF8.GetBytes(counter.ToString());
				udpServer.Send(iterations, iterations.Length, ClientEndPoint);
				foreach (var item in temp)
				{
					udpServer.Send(item, item.Length, ClientEndPoint);
					udpServer.Client.SendTimeout = 10;
				}
			}
		}

		//Определяет IP-адресс удаленного хоста
		//IPHostEntry entry = Dns.GetHostEntry("top-academy.ru");
		//Console.WriteLine(entry.AddressList.FirstOrDefault(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork));
	}
}
