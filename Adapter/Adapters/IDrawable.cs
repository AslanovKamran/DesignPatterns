using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
	internal interface IDrawable
	{
		void Draw(int x1, int x2, int y1, int y2);
	}

	//Class instance realization
	internal class LineAdpater : IDrawable
	{
		private readonly Line adaptee;

		public LineAdpater(Line adaptee) => this.adaptee = adaptee;

		public void Draw(int x1, int x2, int y1, int y2)
		{
			adaptee.X1 = x1; adaptee.Y1 = y1; 
			adaptee.X2 = x2; adaptee.Y2 = y2;

			adaptee.Draw();
		}
	}

	internal class ReactangleAdapter : IDrawable
	{

		private readonly Rectangle adaptee;
		public ReactangleAdapter(Rectangle adaptee) => this.adaptee = adaptee;

		public void Draw(int x1, int x2, int y1, int y2)
		{
			adaptee.X = x1; adaptee.Y = y1;
			adaptee.Width = x2 - x1; 
			adaptee.Height = y2 - y1;

			adaptee.Draw();
		}
	}

	internal class CircleAdapter : IDrawable
	{

		private readonly Circle adaptee;
		public CircleAdapter(Circle adaptee) => this.adaptee = adaptee;

		public void Draw(int x1, int x2, int y1, int y2)
		{
			int radius = (x2 - x1) / 2;
			adaptee.X = x1 + radius; adaptee.Y = y1+radius;
			adaptee.Radius = radius;

			adaptee.Draw();
		}
	}
}
