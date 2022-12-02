using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bridge.Exporters
{
	internal interface IExportable
	{
		void Export(List<string> data, string fileName);
	}

	internal class JsonExporter : IExportable
	{
		public void Export(List<string> data, string fileName)
		{
			var json = JsonConvert.SerializeObject(data);
			File.WriteAllText($"{fileName}.json", json);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Saved into {fileName}.json ");
			Console.ResetColor();
		}
	}

	internal class TxtExporter : IExportable
	{
		public void Export(List<string> data, string fileName)
		{
			var sb = new StringBuilder();
			foreach (var item in data)
			{
				sb.Append(item + Environment.NewLine);
			}
			File.WriteAllText($"{fileName}.txt", sb.ToString());
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Saved into {fileName}.txt ");
			Console.ResetColor();
		}
	}

	internal class XMLExporter : IExportable
	{
		public void Export(List<string> data, string fileName)
		{
			var xmlSerializer = new XmlSerializer(data.GetType());
			using (var fs = new FileStream($"{fileName}.xml", FileMode.OpenOrCreate)) 
			{
				xmlSerializer.Serialize(fs, data);
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Saved into {fileName}.xml ");
			Console.ResetColor();
		}
	}
}
