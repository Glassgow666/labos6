using System;

namespace lab6_os
{
    class Program
    {

		static void DrawCircle()
		{
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("draw circle");
			}

			return;
		}

		static void DrawSquare()
		{
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("draw square");
			}
			return;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Inside main()");
			string typeOfShape="square";
			Console.WriteLine(typeOfShape);

			int i = 0;

			for (; i < 0xffffff; i++) ;
			switch (typeOfShape)
			{
				case "square":
					DrawSquare();
					break;
				case "circle":
					DrawCircle();
					break;
			}

			
		}
	}
}
