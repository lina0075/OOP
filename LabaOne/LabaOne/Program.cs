using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	class Program
	{
		static void Main(string[] args)
		{
			Shape S1 = new Circle(5.5, "RED", false);
			System.Console.WriteLine(S1);
			System.Console.WriteLine(S1.GetArea());
			System.Console.WriteLine(S1.GetPerimeter());
			System.Console.WriteLine(S1.Color);
			System.Console.WriteLine(S1.IsFilled);
			/// Класс Shape не содержит определения для свойства Radius, тут будет ошибка
			//System.Console.WriteLine(S1.Radius);

			Circle C1 = (Circle)S1;
			System.Console.WriteLine(C1);
			System.Console.WriteLine(C1.GetArea());
			System.Console.WriteLine(C1.GetPerimeter());
			System.Console.WriteLine(C1.Color);
			System.Console.WriteLine(C1.IsFilled);
			System.Console.WriteLine(C1.Radius);

			/// Невозможно создать экземпляр абстрактного класса, тут будет ошибка
			//Shape S2 = new Shape();

			Shape S3 = new Rectangle(1.0, 2.0, "RED", false);
			System.Console.WriteLine(S3);
			System.Console.WriteLine(S3.GetArea());
			System.Console.WriteLine(S3.GetPerimeter());
			System.Console.WriteLine(S3.Color);
			/// Класс Shape не содержит определения для свойства Width, тут будет ошибка
			//System.Console.WriteLine(S3.Width);

			Rectangle R1 = (Rectangle)S3;
			System.Console.WriteLine(R1);
			System.Console.WriteLine(R1.GetArea());
			System.Console.WriteLine(R1.Color);
			System.Console.WriteLine(R1.Width);

			Shape S4 = new Square(6.6);
			System.Console.WriteLine(S4);
			System.Console.WriteLine(S4.GetArea());
			System.Console.WriteLine(S4.Color);
			/// Класс Shape не содержит определения для свойства Side, тут будет ошибка
			//System.Console.WriteLine(S4.Side);

			Rectangle R2 = (Rectangle)S4;
			System.Console.WriteLine(R2);
			System.Console.WriteLine(R2.GetArea());
			System.Console.WriteLine(R2.Color);
			/// Класс Rectangle не содержит определения для свойства Side, тут будет ошибка
			//System.Console.WriteLine(R2.Side);
			System.Console.WriteLine(R2.Height);

			Square SQ1 = (Square)R2;
			System.Console.WriteLine(SQ1);
			System.Console.WriteLine(SQ1.GetArea());
			System.Console.WriteLine(SQ1.Color);
			System.Console.WriteLine(SQ1.Side);
			System.Console.WriteLine(SQ1.Height);

			/// Мы не определяли и не реализовывали тип Movable, тут будет ошибка
			/// К тому же, в классе MovablePoint мы не реализовывали конструктор принимающий 3 аргумента
			//Movable m1 = new MovablePoint(5, 6, 10);
			/// Правильное исполнение:
			MovablePoint m1 = new MovablePoint(5, 6, 10, 10);
			System.Console.WriteLine(m1);
			m1.MoveLeft();
			System.Console.WriteLine(m1);

			/// Мы не определяли и не реализовывали тип Movable, тут будет ошибка
			/// К тому же, в классе MovableCircle нет конструктора принимающего 4 аргумента
			//Movable m2 = new MovableCircle(2, 1, 2, 20);
			/// Для правильного исполнение, надо создать экземпляр типа MovablePoint:
			MovablePoint mp = new MovablePoint(3, 7, 13, 13);
			MovableCircle m2 = new MovableCircle(2, mp);
			System.Console.WriteLine(m2);
			m2.MoveLeft();
			System.Console.WriteLine(m2);

			/// Ожидаем нажатия клавиши для закрытия консоли
			System.Console.WriteLine("\r\nPress any key...");
			Console.ReadKey(true);
		}
	}
}
