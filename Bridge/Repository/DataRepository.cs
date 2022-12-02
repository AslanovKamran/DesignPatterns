using Bridge.Exporters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Repository
{
	internal class DataRepository
	{
		public List<string> Data { get; set; }
		public IExportable Exporter { get; set; }

		public DataRepository(List<string> data, IExportable exporter)
		{
			Data = data;
			Exporter = exporter;
		}

		public void AddData(string data)
		{
			Data.Add(data);
		}

		public void RemoveDataAt(int index)
		{
			try
			{
				Data.RemoveAt(index); Console.WriteLine("Removed");

			}
			catch (Exception)
			{
				Console.WriteLine("No data to remove");
			}	
		}

		public void Save(string fileName)
		{
			if (Exporter is not null)
			{
				Exporter.Export(Data, fileName);
			}
			else
			{
				Console.WriteLine("Set the Exporter first");
			}
		}
	}
}
