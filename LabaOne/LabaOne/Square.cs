using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	/// <summary>
	/// Определить класс Square, обозначающий квадрат и наследующий Rectangle
	/// </summary>
	class Square : Rectangle
	{
		/// <summary>
		/// Открытый конструктор без параметров, инициализирующий все поля значениями поумолчанию
		/// </summary>
		public Square()
			: base()
		{
			this.height = this.width;
		}

		/// <summary>
		/// Открытый конструктор с одним параметром, инициализирующий поля width и height указанным значением, а остальные поля значениями по умолчанию
		/// </summary>
		/// <param name="side">Длина стороны</param>
		public Square(double side)
			: base()
		{
			this.width = side;
			this.height = this.width;
		}

		/// <summary>
		/// Открытый конструктор с параметрами инициализирующий все поля
		/// </summary>
		/// <param name="color">Цвет</param>
		/// <param name="filled">Залить</param>
		/// <param name="side">Длина стороны</param>
		public Square(double side, string color, bool filled)
			: base(side, side, color, filled)
		{

		}

		/// <summary>
		/// Открытое свойство Side, возвращающее или задающее размер стороны квадрата
		/// </summary>
		public double Side
		{
			get { return this.width; }
			set { this.width = value; this.height = this.width; }
		}

		/// <summary>
		/// Открытый переопределённый метод GetArea, возвращающий площадь квадрата
		/// </summary>
		/// <returns>Площадь прямоугольника</returns>
		public override double GetArea()
		{
			double area = this.width * this.width;
			return area;
		}
		/// <summary>
		/// Открытый переопределённый метод GetPerimeter, возвращающий длину периметра
		/// </summary>
		/// <returns>Длина периметра</returns>
		public override double GetPerimeter()
		{
			double perimeter = this.width * 4.0;
			return perimeter;
		}

		/// <summary>
		/// Открытый переопределённый метод ToString, возвращающий строку с описанием квадрата
		/// </summary>
		/// <returns>Описание квадрата</returns>
		public override string ToString()
		{
			string info = "Square: " + this.width + " x " + this.height + ", " + this.color;
			info += this.filled ? ", filled" : ", not filled";
			return info;
		}

	}
}
