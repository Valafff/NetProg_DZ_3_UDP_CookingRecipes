using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServerUDP
{
	internal class Config
	{
        public string TextDirectory { get; set; }
        public string ImageDirectory { get; set; }
        public string UsersDirectory { get; set; }

		//Запись и четение конфига
		public void WriteConfig(string _path = "config.json")
		{
			// new JsonSerializerOptions { WriteIndented = true } - перенос на новую строку
			using (FileStream fs = new FileStream(_path, FileMode.Create))
			{
				JsonSerializer.Serialize(fs, this, new JsonSerializerOptions { WriteIndented = true });
			}
		}
		public Config? ReadConfig(string _path = "config.json")
		{
			using (FileStream reader = new FileStream(_path, FileMode.Open))
			{
				return JsonSerializer.Deserialize<Config>(reader);
			}
		}
	}
}
