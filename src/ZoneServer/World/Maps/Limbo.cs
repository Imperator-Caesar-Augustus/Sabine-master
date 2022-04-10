﻿using Sabine.Zone.World.Entities;

namespace Sabine.Zone.World.Maps
{
	/// <summary>
	/// A dummy map that is used in characters so they never have
	/// a null map that could cause exceptions.
	/// </summary>
	public class Limbo : Map
	{
		/// <summary>
		/// Creates new instance.
		/// </summary>
		public Limbo()
			: base("__limbo__")
		{
		}

		/// <summary>
		/// Does nothing.
		/// </summary>
		/// <param name="character"></param>
		public override void AddCharacter(PlayerCharacter character)
		{
		}

		/// <summary>
		/// Does nothing.
		/// </summary>
		/// <param name="character"></param>
		public override void RemoveCharacter(PlayerCharacter character)
		{
		}
	}
}
