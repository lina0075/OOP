using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	/// <summary>
	/// Определить класс MovableRectangle, обозначающий прямоугольник и реализующий интерфейс IMovable
	/// </summary>
	class MovableRectangle : IMovable
	{
		private MovablePoint topLeft;
		private MovablePoint bottomRight;

		/// <summary>
		/// Конструктор с параметрами инициализирующий все поля класса
		/// </summary>
		/// <param name="topLeft">Координаты верхнего левого угла</param>
		/// <param name="bottomRight">Координаты нижнего правого угла</param>
		public MovableRectangle(MovablePoint topLeft, MovablePoint bottomRight)
		{
			this.topLeft = topLeft;
			this.bottomRight = bottomRight;
		}

		#region Реализация методов интерфеса IMovable

		/// <summary>
		/// Реализация метода MoveUp из интерфейса IMovable
		/// </summary>
		public void MoveUp()
		{
			this.topLeft.MoveUp();
			this.bottomRight.MoveUp();
		}

		/// <summary>
		/// Реализация метода MoveDown из интерфейса IMovable
		/// </summary>
		public void MoveDown()
		{
			this.topLeft.MoveDown();
			this.bottomRight.MoveDown();
		}

		/// <summary>
		/// Реализация метода MoveLeft из интерфейса IMovable
		/// </summary>
		public void MoveLeft()
		{
			this.topLeft.MoveLeft();
			this.bottomRight.MoveLeft();
		}

		/// <summary>
		/// Реализация метода MoveRight из интерфейса IMovable
		/// </summary>
		public void MoveRight()
		{
			this.topLeft.MoveRight();
			this.bottomRight.MoveRight();
		}

		#endregion

		/// <summary>
		/// Открытый переопределённый метод ToString, возвращающий строку с описанием прямоугольника
		/// </summary>
		/// <returns>Описание прямоугольника</returns>
		public override string ToString()
		{
			/// Так как все поля класса MovablePoint защищены "protected" и нет открытых свойст для их получения
			/// мы не можем расчитать размер и положение прямоугольника.
			string info = "MovableRectangle - нет возможности получить информацию о размере и положении";
			return info;
		}

	}
}
