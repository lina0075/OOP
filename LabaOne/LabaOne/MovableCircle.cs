using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	/// <summary>
	/// Определить класс MovableCircle, обозначающий окружность и реализующий интерфейс  IMovable
	/// </summary>
	class MovableCircle : IMovable
	{
		private int radius;
		private MovablePoint center;

		/// <summary>
		/// Конструктор с параметрами инициализирующий все поля класса
		/// </summary>
		/// <param name="radius">Радиус</param>
		/// <param name="center">Координаты</param>
		public MovableCircle(int radius, MovablePoint center)
		{
			this.radius = radius;
			this.center = center;
		}

		#region Реализация методов интерфеса IMovable

		/// <summary>
		/// Реализация метода MoveUp из интерфейса IMovable
		/// </summary>
		public void MoveUp()
		{
			this.center.MoveUp();
		}

		/// <summary>
		/// Реализация метода MoveDown из интерфейса IMovable
		/// </summary>
		public void MoveDown()
		{
			this.center.MoveDown();
		}

		/// <summary>
		/// Реализация метода MoveLeft из интерфейса IMovable
		/// </summary>
		public void MoveLeft()
		{
			this.center.MoveLeft();
		}

		/// <summary>
		/// Реализация метода MoveRight из интерфейса IMovable
		/// </summary>
		public void MoveRight()
		{
			this.center.MoveRight();
		}

		#endregion

		/// <summary>
		/// Открытый переопределённый метод ToString, возвращающий строку с описанием окружности
		/// </summary>
		/// <returns>Описание окружности</returns>
		public override string ToString()
		{
			/// Так как все поля класса MovablePoint защищены "protected" и нет открытых свойст для их получения
			/// мы не можем расчитать положение окружности.
			string info = "MovableCircle - Radius: " + this.radius;
			return info;
		}

	}
}
