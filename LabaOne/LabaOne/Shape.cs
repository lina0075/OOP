using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	/// <summary>
	/// Определить абстрактный класс Shape, обозначающий фигуру
	/// </summary>
	abstract class Shape
	{
		protected string color;
		protected bool filled;

		/// <summary>
		/// Открытый конструктор без параметров, инициализирующий все поля значениями поумолчанию.
		/// </summary>
		public Shape()
		{
			this.color = "FUCHSIA";
			this.filled = true;
		}

		/// <summary>
		/// Открытый конструктор с параметрами инициализирующий все поля указанными значениями
		/// </summary>
		/// <param name="color">Цвет</param>
		/// <param name="filled">Заливка</param>
		public Shape(string color, bool filled)
		{
			this.color = color;
			this.filled = filled;
		}

		/// <summary>
		/// Открытое свойство Color, возвращающее или задающее значение поля color
		/// </summary>
		public string Color
		{
			get { return this.color; }
			set { this.color = value; }
		}

		/// <summary>
		/// Открытое свойство IsFilled, возвращающее или задающее значение поля filled
		/// </summary>
		public bool IsFilled
		{
			get { return this.filled; }
			set { this.filled = value; }
		}

		/// <summary>
		/// Открытый абстрактный метод GetArea для получения площади фигуры
		/// </summary>
		/// <returns>Площадь</returns>
		public abstract double GetArea();

		/// <summary>
		/// Открытый абстрактный метод GetPerimeter для получения периметра фигуры
		/// </summary>
		/// <returns>Периметр</returns>
		public abstract double GetPerimeter();

		/// <summary>
		/// Открытый переопределённый метод ToString, возвращающий строку с описанием фигуры
		/// </summary>
		/// <returns>Описание фигуры</returns>
		public override string ToString()
		{
			string info = "Shape: " + this.color;
			info += this.filled ? ", filled" : ", not filled";
			return info;
		}
	}
}
