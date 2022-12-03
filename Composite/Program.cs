using Composite.Models;
using File = Composite.Models.File;

namespace Composite
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Component root = new Folder("root");
			File fileA = new File("A");
			root.Add(fileA);
			root.Add(new File("File B"));

			Component component1 = new Folder("FolderX");

			component1.Add(new File("File X->A"));
			component1.Add(new File("File X->B"));

			root.Add(component1);

			Component component2 = new Folder("Folder Y",new List<Component>()
			{
				new File("File Y->A"),
				new File("File Y->B"),
			});


			Component component3 = new Folder("Subfolder of Y Folder");
			component3.Add(new File("Subfile Y->A"));
			component3.Add(new File("Subfile Y->B"));

			component2.Add(component3);
			root.Add(component2);

			File file = new File("File C");
			root.Add(file);

			root.Display();
		}
	}
}