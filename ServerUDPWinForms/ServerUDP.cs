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
	//Для передачи данных через событие
	public delegate void MessageFromServer(string s);

	//Работает в режиме приема и передачи
	public class ServerUDP
	{   //Извещение об отправлении сообщения
		public event MessageFromServer MessageFromServerEvent;

		public int serverPort = 2222;
		public int MaxClientConnected = 5;
		public int MaxClientRequest = 5;
		public int ClientTimeLimit = 15;


		UdpClient udpServer = new UdpClient();
		IPEndPoint ClientEndPoint = null;
		List<Client> clientsPool = new List<Client>();
		public List<Recipe> Recipes = new List<Recipe>();
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
		//Предача данных через событие
		public void SendServiceMessege(string _inputmessage)
		{
			string timeNow = (DateTime.Now.Date + DateTime.Now.TimeOfDay).ToString();

			MessageFromServerEvent(_inputmessage + "\t" + timeNow);
		}

		public void StopServer()
		{
			udpServer.Close();
			SendServiceMessege("Сервер остановлен!");
		}

		public void ServerStart()
		{
			SendServiceMessege($"Сервер запущен! Размер буфера на прием равен {udpServer.Client.ReceiveBufferSize} Размер буфера на передачу равен {udpServer.Client.SendBufferSize}");
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
							SendServiceMessege($"Количество подключенных пользователей: {clientsPool.Count}");
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
							SendServiceMessege($"Конечная точка клиента:{ClientEndPoint.Address} {ClientEndPoint.Port}");
							SendServiceMessege($"Запрос клиента {ClientEndPoint.Address} {ClientEndPoint.Port}: {res}");

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
							string answer = $"Клиент {ClientEndPoint} превысил количество возможных запросов. Доступ будет разрешен через {clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).shutDownTime - DateTime.UtcNow}";
							udpServer.Send(Encoding.UTF8.GetBytes(answer), Encoding.UTF8.GetBytes(answer).Length, ClientEndPoint);
							SendServiceMessege(answer);
							if (clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).shutDownTime < DateTime.UtcNow)
							{
								clientsPool.Find(f => f.EndPoint.Port == ClientEndPoint.Port).RequesNumber = 0;
							}
						}
						else
						{
							string answer = $"Сервер не может обрабатывать запросы более {MaxClientConnected} пользователей";
							udpServer.Send(Encoding.UTF8.GetBytes(answer), Encoding.UTF8.GetBytes(answer).Length, ClientEndPoint);
							SendServiceMessege(answer);
						}
					}
				}
				catch (Exception ex)
				{
					SendServiceMessege(ex.Message);
				}
				finally
				{
					clientsPool.Clear();
					udpServer.Close();
					SendServiceMessege($"Переподключение!");
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
						SendServiceMessege($"Клиент {item.EndPoint} делал запрос {(timeNow - item.connTime) / 10000000} секунд назад");
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
					SendServiceMessege($"Текущее количество активных клиентов: {clientsPool.Count}");
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
	}
}
