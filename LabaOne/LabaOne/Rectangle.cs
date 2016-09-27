using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	/// <summary>
	/// Определить класс Rectangle, обозначающий прямоугольник и наследующий Shape
	/// </summary>
	class Rectangle : Shape
	{ 
		protected double width;
		protected double height;

		/// <summary>
		/// Открытый конструктор без параметров, инициализирующий все поля значениями поумолчанию
		/// </summary>
		public Rectangle()
			: base ()
		{
			this.width = 30.0;
			this.height = 30.0;
		}

		/// <summary>
		/// Открытый конструктор с двумя параметрами, инициализирующий поля width и height указанными значениями, а остальные поля значениями по умолчанию
		/// </summary>
		/// <param name="width">Ширина</param>
		/// <param name="height">Высота</param>
		public Rectangle(double width, double height)
			: base()
		{
			this.width = width;
			this.height = height;
		}

		/// <summary>
		/// Открытый конструктор с параметрами инициализирующий все поля
		/// </summary>
		/// <param name="width">Ширина</param>
		/// <param name="height">Высота</param>
		/// <param name="color">Цвет</param>
		/// <param name="filled">Залить</param>
		public Rectangle(double width, double height, string color, bool filled)
			: base(color, filled)
		{
			this.width = width;
			this.height = height;
		}

		/// <summary>
		/// Открытое свойство Width, возвращающее или задающее значение поля width
		/// </summary>
		public double Width
		{
			get { return this.width; }
			set { this.width = value; }
		}

		/// <summary>
		/// Открытое свойство Height, возвращающее или задающее значение поля height
		/// </summary>
		public double Height
		{
			get { return this.height; }
			set { this.height = value; }
		}

		/// <summary>
		/// Открытый переопределённый метод GetArea, возвращающий площадь прямоугольника
		/// </summary>
		/// <returns>Площадь прямоугольника</returns>
		public override double GetArea()
		{
			double area = this.width * this.height;
			return area;
		}
		/// <summary>
		/// Открытый переопределённый метод GetPerimeter, возвращающий длину периметра
		/// </summary>
		/// <returns>Длина периметра</returns>
		public override double GetPerimeter()
		{
			double perimeter = (this.width * 2.0) + (this.height * 2.0);
			return perimeter;
		}

		/// <summary>
		/// Открытый переопределённый метод ToString, возвращающий строку с описанием прямоугольника
		/// </summary>
		/// <returns>Описание прямоугольника</returns>
		public override string ToString()
		{
			string info = "Rectangle: " + this.width + " x " + this.height + ", " + this.color;
			info += this.filled ? ", filled" : ", not filled";
			return info;
		}

	}
}
