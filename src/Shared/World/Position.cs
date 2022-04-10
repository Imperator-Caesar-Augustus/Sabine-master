﻿namespace Sabine.Shared.World
{
	/// <summary>
	/// Represents a position in the world.
	/// </summary>
	public struct Position
	{
		/// <summary>
		/// The X-coordinate of the position.
		/// </summary>
		public int X;

		/// <summary>
		/// The Y-coordinate of the position.
		/// </summary>
		public int Y;

		/// <summary>
		/// Creates new position.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public Position(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		/// <summary>
		/// Returns true if the position's coordinates are the same.
		/// </summary>
		/// <param name="pos1"></param>
		/// <param name="pos2"></param>
		/// <returns></returns>
		public static bool operator ==(Position pos1, Position pos2)
		{
			return (pos1.X == pos2.X && pos1.Y == pos2.Y);
		}

		/// <summary>
		/// Returns true if the position's coordinates are not the same.
		/// </summary>
		/// <param name="pos1"></param>
		/// <param name="pos2"></param>
		/// <returns></returns>
		public static bool operator !=(Position pos1, Position pos2)
		{
			return !(pos1 == pos2);
		}

		/// <summary>
		/// Returns a hash code for this position that will equal positions
		/// with the same coordinates.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return this.X.GetHashCode() ^ this.Y.GetHashCode();
		}

		/// <summary>
		/// Returns true if the given object is this exact position instance.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return obj is Position && this == (Position)obj;
		}

		/// <summary>
		/// Returns a string representation of this position.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("(Position - X: {0}, Y: {1})", this.X, this.Y);
		}
	}
}
