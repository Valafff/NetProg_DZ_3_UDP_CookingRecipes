using ServerUDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerUDPWinForms
{

	public partial class ServerForm : Form
	{
		bool isrunning = false;
		public ServerForm()
		{
			List<Recipe> Recipes = new List<Recipe>();
			InitializeComponent();
		}

		private void buttonStartStopServer_Click(object sender, EventArgs e)
		{
			try
			{
				RecipesLoader Loader = new RecipesLoader();
				List<Recipe> Recipes = Loader.GetRecipes();
				listBoxLoadedDocs.DataSource = Recipes;
				listBoxLoadedDocs.DisplayMember = "RecipeName";
				ServerUDP.ServerUDP serverUDP = new ServerUDP.ServerUDP(Recipes);
				serverUDP.serverPort = Int32.Parse(textBoxServerPort.Text);
				serverUDP.MaxClientConnected = Int32.Parse(textBoxClientsLimit.Text);
				serverUDP.MaxClientRequest = Int32.Parse(textBoxRequestLimit.Text);
				serverUDP.ClientTimeLimit = Int32.Parse(textBoxClientTimeOut.Text);

				//Для получения данных - событие с передачей аргумента string см. ServerUDP
				serverUDP.MessageFromServerEvent += AddNewRecordFromServer;

				if (!isrunning)
				{
					Task.Run(new Action(() => serverUDP.ServerStart()));
					
					buttonStartStopServer.Text = "Остановка сервера";
					labelServerStatus.ForeColor = Color.Green;
					labelServerStatus.Text = "Статус сервера: РАБОТАЕТ";
					isrunning = true;
				}
				else
				{
					serverUDP.StopServer();

					buttonStartStopServer.Text = "Запуск сервера";
					labelServerStatus.ForeColor = Color.Red;
					labelServerStatus.Text = "Статус сервера: НЕ ЗАПУЩЕН";
					isrunning = false;
				}

			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//Для получения данных - событие с передачей аргумента string см. ServerUDP
		public void  AddNewRecordFromServer(string _input)
		{
		 	richTextBoxServerMesseges.Text += (_input+ '\n');
			using(StreamWriter sw = new StreamWriter("logfile.txt", true, Encoding.UTF8 ))
			{
				sw.WriteLine(_input);
			}
		}
	}
}
