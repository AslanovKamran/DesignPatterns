using FactoryMethod.Unit;

namespace FactoryMethod.Creators
{
	interface IFigureCreator
	{
		Figure CreateFigure(); 
	}

	class SquareCreator: IFigureCreator
	{
		public Figure CreateFigure() => new FigureSquare();
	}

	class LineCreator : IFigureCreator
	{
		public Figure CreateFigure() => new FigureLine();
	}

	class ZCreator : IFigureCreator
	{
		public Figure CreateFigure() => new FigureZ();
	}

	class LCreator : IFigureCreator
	{
		public Figure CreateFigure() => new FigureL();
	}

	class TCreator : IFigureCreator
	{
		public Figure CreateFigure() => new FigureT();
	}


}
