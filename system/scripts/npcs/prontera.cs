﻿//--- Sabine Script ---------------------------------------------------------
// Prontera NPCs
//--- Description -----------------------------------------------------------
// Sets up NPCs stationed in the general Prontera area.
//---------------------------------------------------------------------------

using Sabine.Zone.Scripting;
using static Sabine.Zone.Scripting.Shortcuts;

public class PronteraNpcsScript : MapScript
{
	public override void Load()
	{
		AddNpc("Guide", 54, "prt_vilg02", 99, 89, async dialog =>
		{
			dialog.Msg("[Guide]");
			dialog.Msg("Hello, world!");
			await dialog.Next();

			dialog.Msg("[Guide]");
			dialog.Msg("How are you?");
			await dialog.Next();

			var response = await dialog.Select(Option("Good!", "good"), Option("Meh.", "bad"));

			dialog.Msg("[Guide]");
			switch (response)
			{
				case "good": dialog.Msg("That's nice to hear!"); break;
				case "bad": dialog.Msg("Toughen up!"); break;
			}

			// Move along, just having fun here.

			//dialog.AthenaFTW(out var mes, out var next, out var select);

			//mes("[Guide]");
			//mes("Hello, world!");
			//await next();

			//mes("[Guide]");
			//mes("How are you?");
			//await next();

			//var response = await select("Good!", "Meh");

			//mes("[Guide]");
			//switch (response)
			//{
			//	case 1: mes("That's nice to hear!"); break;
			//	case 2: mes("Toughen up!"); break;
			//}

			// Style test for how NPCs could look like. Msg would always
			// send a wait at the end and codes like p and br could be
			// used to split up the message. The NPC's name would become
			// the default title and always be displayed with each
			// message, unless unset.

			//await dialog.MsgAdv("Hello, world!<p/>How are you?");
			//var response = await dialog.Select(Option("Good!", "good"), Option("Meh.", "bad"));

			//switch (response)
			//{
			//	case "good": await dialog.MsgAdv("That's nice to hear!"); break;
			//	case "bad": await dialog.MsgAdv("Toughen up!"); break;
			//}
		});
	}
}