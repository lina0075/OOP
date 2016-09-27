using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	/// <summary>
	/// Определить класс MovablePoint, обозначающий точку и реализующий интерфейс IMovable
	/// </summary>
	class MovablePoint : IMovable
	{
		protected int x;
		protected int y;
		protected int xSpeed;
		protected int ySpeed;

		/// <summary>
		/// Конструктор с параметрами инициализирующими все поля класса
		/// </summary>
		/// <param name="x">Положение по оси X</param>
		/// <param name="y">Положение по оси Y</param>
		/// <param name="xSpeed">Скорость по оси X</param>
		/// <param name="ySpeed">Скорость по оси Y</param>
		public MovablePoint(int x, int y, int xSpeed, int ySpeed)
		{
			this.x = x;
			this.y = y;
			this.xSpeed = xSpeed;
			this.ySpeed = ySpeed;
		}

		#region Реализация методов интерфеса IMovable

		/// <summary>
		/// Реализация метода MoveUp из интерфейса IMovable
		/// </summary>
		public void MoveUp()
		{
			this.y += this.ySpeed;
		}

		/// <summary>
		/// Реализация метода MoveDown из интерфейса IMovable
		/// </summary>
		public void MoveDown()
		{
			this.y -= this.ySpeed;
		}

		/// <summary>
		/// Реализация метода MoveLeft из интерфейса IMovable
		/// </summary>
		public void MoveLeft()
		{
			this.x -= this.xSpeed;
		}

		/// <summary>
		/// Реализация метода MoveRight из интерфейса IMovable
		/// </summary>
		public void MoveRight()
		{
			this.x += this.xSpeed;
		}

		#endregion

		/// <summary>
		/// Открытый переопределённый метод ToString, возвращающий строку с описанием точки
		/// </summary>
		/// <returns>Описание точки</returns>
		public override string ToString()
		{
			string info = "MovablePoint - Position: " + this.x + " x " + this.y + ", X step: " + this.xSpeed + ", Y step: " + this.ySpeed;
			return info;
		}

	}
}
