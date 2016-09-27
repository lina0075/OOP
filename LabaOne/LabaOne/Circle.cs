using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	/// <summary>
	/// Определить класс Circle, обозначающий окружность и наследующий Shape
	/// </summary>
	class Circle : Shape
	{
		protected double radius;
		
		/// <summary>
		/// Открытый конструктор без параметров, инициализирующий все поля значениями поумолчанию
		/// </summary>
		public Circle()
			: base ()
		{
			this.radius = 30.0;
		}

		/// <summary>
		/// Открытый конструктор с параметром, инициализирующий поле radius указанным значением, а остальные поля значениями по умолчанию
		/// </summary>
		/// <param name="radius">Радиус</param>
		public Circle(double radius)
			: base ()
		{
			this.radius = radius;
		}

		/// <summary>
		/// Открытый конструктор с параметрами инициализирующий все поля
		/// </summary>
		/// <param name="radius">Радиус</param>
		/// <param name="color">Цвет</param>
		/// <param name="filled">Залить</param>
		public Circle(double radius, string color, bool filled)
			: base (color, filled)
		{
			this.radius = radius;
		}

		/// <summary>
		/// Открытое свойство Radius, возвращающее или задающее значение поля radius
		/// </summary>
		public double Radius
		{
			get { return this.radius; }
			set { this.radius = value; }
		}

		/// <summary>
		/// Открытый переопределённый метод GetArea, возвращающий площадь круга, описываемого окружностью.
		/// </summary>
		/// <returns>Площадь круга</returns>
		public override double GetArea()
		{
			/// π r2
			double area = Math.PI * this.radius * this.radius;
			return area;
		}

		/// <summary>
		/// Открытый переопределённый метод GetPerimeter, возвращающий длину окружности
		/// </summary>
		/// <returns>Длина окружности</returns>
		public override double GetPerimeter()
		{
			/// 2π r
			double circuit = 2.0 * Math.PI * this.radius;
			return circuit;
		}

		/// <summary>
		/// Открытый переопределённый метод ToString, возвращающий строку с описанием окружности
		/// </summary>
		/// <returns>Описание окружности</returns>
		public override string ToString()
		{
			string info = "Circle: R" + this.radius + ", " + this.color;
			info += this.filled ? ", filled" : ", not filled";
			return info;
		}
	}
}
