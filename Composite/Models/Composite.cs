using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Models
{
	public abstract class Component
	{
		protected string Name;
		protected Component(string name) => Name = name;

		public abstract void Add(Component component);
		public abstract void RemoveComponent(Component component);
		public abstract void Display(int depth = 0);

	}

	//Composite
	public class Folder : Component
	{
		public List<Component> Children;
		public Folder(string name) : base(name) => Children = new();
		public Folder(string name, List<Component> components) : base(name) => Children = components;

		public override void Add(Component component)
		{
			Children.Add(component);
		}
		public override void RemoveComponent(Component component)
		{
			Children.Remove(component);
		}

		public override void Display(int depth = 0)
		{
			Console.WriteLine(new string('-', depth) + Name);

			foreach (var component in Children)
			{
				component.Display(depth + 2);
			}
		}
	}

	//Leaf
	public class File : Component
	{
		public File(string name) : base(name) { }

		public override void Add(Component component)
		{
			Console.WriteLine("Cannot add component to the file");
		}

		public override void RemoveComponent(Component component)
		{
			Console.WriteLine("Cannot remove component from the file");
		}

		public override void Display(int depth = 0)
		{
			 Console.WriteLine(new string('-', depth) + Name);
		}
	}

}
