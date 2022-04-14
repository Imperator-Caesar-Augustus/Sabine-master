﻿using Yggdrasil.Logging;
using Yggdrasil.Util.Commands;

namespace Sabine.Zone.Commands
{
	/// <summary>
	/// Console command handler.
	/// </summary>
	public class ConsoleCommands : Yggdrasil.Util.Commands.ConsoleCommands
	{
		/// <summary>
		/// Shows an overview of the server's status.
		/// </summary>
		/// <param name="command"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		protected override CommandResult HandleStatus(string command, Arguments args)
		{
			base.HandleStatus(command, args);

			Log.Info("Updates Per Second: {0:0.0}", ZoneServer.Instance.World.Heartbeat.UpdatesPerSecond);
			Log.Info("Average Update Time: {0:0.0}ms", ZoneServer.Instance.World.Heartbeat.AverageUpdateTime.TotalMilliseconds);
			Log.Info("Players in World: {0}", ZoneServer.Instance.World.GetPlayerCount());

			return CommandResult.Okay;
		}
	}
}
