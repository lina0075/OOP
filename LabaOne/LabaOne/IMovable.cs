using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOne
{
	/// <summary>
	/// Определить интерфейс IMovable
	/// </summary>
	public interface IMovable
	{
		void MoveUp();
		void MoveDown();
		void MoveLeft();
		void MoveRight();
	}
}
