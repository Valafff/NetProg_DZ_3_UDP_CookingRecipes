using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerUDP;

namespace ClientWindowsForms
{
	public partial class UDPClientForm : Form
	{
		ClientUDP client = new ClientUDP();
		bool flag = false;
		public UDPClientForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (IPAddress.TryParse(textBoxIPaddress.Text, out IPAddress ServerIp) && Int32.TryParse(textBoxPort.Text, out int ServerPort))
				{
					client.ReceivingEndPont = new IPEndPoint(ServerIp, ServerPort);
					client.udpRequestSender.Connect(client.ReceivingEndPont);
					flag = true;
					MessageBox.Show("Настройки подключения заданы");
				}
				else MessageBox.Show("Введены некорректные данные");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private async void buttonSearch_Click(object sender, EventArgs e)
		{
			if (flag)
			{
				richTextBoxServerAnswer.Clear();
				try
				{
					if (textBoxRequest.Text != "")
					{
						Task.Run(new Action(() => client.SendRequest(textBoxRequest.Text)));
						Task.Run(new Action(() => client.ReciveFromServer()));
						client.DataFromServerEvent += WriteToRichTextbox;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Не установлены настройки соединения");
			}
		}

		void WriteToRichTextbox(object _input)
		{	
			richTextBoxServerAnswer.Text += _input.ToString();
			richTextBoxServerAnswer.Text += '\n';
		}
	}
}
