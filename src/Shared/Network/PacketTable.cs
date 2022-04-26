﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Sabine.Shared.Network
{
	/// <summary>
	/// Manages a list of packet opcodes and their lengths.
	/// </summary>
	public static class PacketTable
	{
		static PacketTable()
		{
			// Piecing it together bit by bit, some ops are guessed.

			Register(Op.CA_LOGIN, 0x0000, 54);
			Register(Op.CH_ENTER, 0x0001, 17);
			Register(Op.CH_SELECT_CHAR, 0x0002, 3);
			Register(Op.CH_MAKE_CHAR, 0x0003, 34);
			Register(Op.CH_DELETE_CHAR, 0x0004, 46);
			Register(Op.AC_ACCEPT_LOGIN, 0x0005, -1);
			Register(Op.AC_REFUSE_LOGIN, 0x0006, 3);
			Register(Op.HC_ACCEPT_ENTER, 0x0007, -1);
			Register(Op.HC_REFUSE_ENTER, 0x0008, 3);
			Register(Op.HC_ACCEPT_MAKECHAR, 0x0009, 92);
			Register(Op.HC_REFUSE_MAKECHAR, 0x000A, 3);
			Register(Op.HC_ACCEPT_DELETECHAR, 0x000B, 2);
			Register(Op.HC_REFUSE_DELETECHAR, 0x000C, 3);
			Register(Op.HC_NOTIFY_ZONESVR, 0x000D, 28);
			Register(Op.CZ_ENTER, 0x000E, 19);
			Register(Op.ZC_ACCEPT_ENTER, 0x000F, 11);
			Register(Op.ZC_REFUSE_ENTER, 0x0010, 3);
			Register(Op.ZC_NOTIFY_INITCHAR, 0x0011, -1); // Unused in alpha
			Register(Op.ZC_NOTIFY_UPDATECHAR, 0x0012, 9); // Unused in alpha
			Register(Op.ZC_NOTIFY_UPDATEPLAYER, 0x0013, 5); // Unused in alpha
			Register(Op.ZC_NOTIFY_STANDENTRY, 0x0014, 26);
			Register(Op.ZC_NOTIFY_NEWENTRY, 0x0015, 25);
			Register(Op.ZC_NOTIFY_ACTENTRY, 0x0016, 30); // Unused in alpha
			Register(Op.ZC_NOTIFY_MOVEENTRY, 0x0017, 32);
			Register(Op.ZC_NOTIFY_STANDENTRY_NPC, 0x0018, 25);
			Register(Op.CZ_NOTIFY_ACTORINIT, 0x0019, 2);
			Register(Op.CZ_REQUEST_TIME, 0x001A, 6);
			Register(Op.ZC_NOTIFY_TIME, 0x001B, 6);
			Register(Op.ZC_NOTIFY_VANISH, 0x001C, 7);
			Register(Op.SC_NOTIFY_BAN, 0x001D, 3);
			Register(Op.CZ_REQUEST_QUIT, 0x001E, 2); // Presumably unused in alpha
			Register(Op.ZC_ACCEPT_QUIT, 0x001F, 2); // Unused in alpha
			Register(Op.ZC_REFUSE_QUIT, 0x0020, 2); // Unused in alpha
			Register(Op.CZ_REQUEST_MOVE, 0x0021, 5);
			Register(Op.ZC_NOTIFY_MOVE, 0x0022, 16);
			Register(Op.ZC_NOTIFY_PLAYERMOVE, 0x0023, 12);
			Register(Op.ZC_STOPMOVE, 0x0024, 10);
			Register(Op.CZ_REQUEST_ACT, 0x0025, 7);
			Register(Op.ZC_NOTIFY_ACT, 0x0026, 27);
			Register(Op.ZC_NOTIFY_ACT_POSITION, 0x0027, 23); // Added in Beta1
			Register(Op.CZ_REQUEST_CHAT, 0x0028, -1);
			Register(Op.ZC_NOTIFY_CHAT, 0x0029, -1);
			Register(Op.ZC_NOTIFY_PLAYERCHAT, 0x002A, -1);
			//Register(Op.SERVER_ENTRY_ACK, 0x002B, ?); // Not in client's packet table
			Register(Op.CZ_CONTACTNPC, 0x002C, 7);
			Register(Op.ZC_NPCACK_MAPMOVE, 0x002D, 22);
			Register(Op.ZC_NPCACK_SERVERMOVE, 0x002E, 28);
			Register(Op.ZC_NPCACK_ENABLE, 0x002F, 2);
			Register(Op.CZ_REQNAME, 0x0030, 6);
			Register(Op.ZC_ACK_REQNAME, 0x0031, 54);
			Register(Op.CZ_WHISPER, 0x0032, -1);
			Register(Op.ZC_WHISPER, 0x0033, -1);
			Register(Op.ZC_ACK_WHISPER, 0x0034, 3);
			Register(Op.CZ_BROADCAST, 0x0035, -1);
			Register(Op.ZC_BROADCAST, 0x0036, -1);
			Register(Op.CZ_CHANGE_DIRECTION, 0x0037, 3);
			Register(Op.ZC_CHANGE_DIRECTION, 0x0038, 7);
			Register(Op.ZC_ITEM_ENTRY, 0x0039, 38);
			Register(Op.ZC_ITEM_FALL_ENTRY, 0x003A, 38);
			Register(Op.CZ_ITEM_PICKUP, 0x003B, 6);
			Register(Op.ZC_ITEM_PICKUP_ACK, 0x003C, 33);
			Register(Op.ZC_ITEM_DISAPPEAR, 0x003D, 6);
			Register(Op.CZ_ITEM_THROW, 0x003E, 6);
			Register(Op.ZC_NORMAL_ITEMLIST, 0x003F, -1);
			Register(Op.ZC_EQUIPMENT_ITEMLIST, 0x0040, -1);
			Register(Op.ZC_STORE_NORMAL_ITEMLIST, 0x0041, -1);
			Register(Op.ZC_STORE_EQUIPMENT_ITEMLIST, 0x0042, -1);
			Register(Op.CZ_USE_ITEM, 0x0043, 8);
			Register(Op.ZC_USE_ITEM_ACK, 0x0044, 7);
			Register(Op.CZ_REQ_WEAR_EQUIP, 0x0045, 5);
			Register(Op.ZC_REQ_WEAR_EQUIP_ACK, 0x0046, 6);
			Register(Op.CZ_REQ_TAKEOFF_EQUIP, 0x0047, 4);
			Register(Op.ZC_REQ_TAKEOFF_EQUIP_ACK, 0x0048, 6);
			Register(Op.CZ_REQ_ITEM_EXPLANATION_BYNAME, 0x0049, 26);
			Register(Op.ZC_REQ_ITEM_EXPLANATION_ACK, 0x004A, -1);
			Register(Op.ZC_ITEM_THROW_ACK, 0x004B, 6);
			Register(Op.ZC_PAR_CHANGE, 0x004C, 6);
			Register(Op.ZC_LONGPAR_CHANGE, 0x004D, 8);
			Register(Op.CZ_RESTART, 0x004E, 3);
			Register(Op.ZC_RESTART_ACK, 0x004F, 3);
			Register(Op.ZC_SAY_DIALOG, 0x0050, -1);
			Register(Op.ZC_WAIT_DIALOG, 0x0051, 6);
			Register(Op.ZC_CLOSE_DIALOG, 0x0052, 6);
			Register(Op.ZC_MENU_LIST, 0x0053, -1);
			Register(Op.CZ_CHOOSE_MENU, 0x0054, 7);
			Register(Op.CZ_REQ_NEXT_SCRIPT, 0x0055, 6);
			Register(Op.CZ_REQ_STATUS, 0x0056, 2);
			Register(Op.CZ_STATUS_CHANGE, 0x0057, 5);
			Register(Op.ZC_STATUS_CHANGE_ACK, 0x0058, 6);
			Register(Op.ZC_STATUS, 0x0059, 44);
			Register(Op.ZC_STATUS_CHANGE, 0x005A, 5);
			Register(Op.CZ_REQ_EMOTION, 0x005B, 3);
			Register(Op.ZC_EMOTION, 0x005C, 7);
			Register(Op.CZ_REQ_USER_COUNT, 0x005D, 2);
			Register(Op.ZC_USER_COUNT, 0x005E, 6);
			Register(Op.ZC_SPRITE_CHANGE, 0x005F, 8);
			Register(Op.ZC_SELECT_DEALTYPE, 0x0060, 6);
			Register(Op.CZ_ACK_SELECT_DEALTYPE, 0x0061, 7);
			Register(Op.ZC_PC_PURCHASE_ITEMLIST, 0x0062, -1);
			Register(Op.ZC_PC_SELL_ITEMLIST, 0x0063, -1);
			Register(Op.CZ_PC_PURCHASE_ITEMLIST, 0x0064, -1);
			Register(Op.CZ_PC_SELL_ITEMLIST, 0x0065, -1);
			Register(Op.ZC_PC_PURCHASE_RESULT, 0x0066, 3);
			Register(Op.ZC_PC_SELL_RESULT, 0x0067, 3);
			Register(Op.CZ_DISCONNECT_CHARACTER, 0x0068, 26);
			Register(Op.ZC_ACK_DISCONNECT_CHARACTER, 0x0069, 3);
			Register(Op.CZ_DISCONNECT_ALL_CHARACTER, 0x006A, 2);
			Register(Op.CZ_SETTING_WHISPER_PC, 0x006B, 27);
			Register(Op.CZ_SETTING_WHISPER_STATE, 0x006C, 3);
			Register(Op.ZC_SETTING_WHISPER_PC, 0x006D, 4);
			Register(Op.ZC_SETTING_WHISPER_STATE, 0x006E, 4);
			Register(Op.CZ_REQ_WHISPER_LIST, 0x006F, 2);
			Register(Op.ZC_WHISPER_LIST, 0x0070, -1);
			Register(Op.CZ_CREATE_CHATROOM, 0x0071, -1);
			Register(Op.ZC_ACK_CREATE_CHATROOM, 0x0072, 3);
			Register(Op.ZC_ROOM_NEWENTRY, 0x0073, -1);
			Register(Op.ZC_DESTROY_ROOM, 0x0074, 6);
			Register(Op.CZ_REQ_ENTER_ROOM, 0x0075, 14);
			Register(Op.ZC_REFUSE_ENTER_ROOM, 0x0076, 3);
			Register(Op.ZC_ENTER_ROOM, 0x0077, -1);
			Register(Op.ZC_MEMBER_NEWENTRY, 0x0078, 28);
			Register(Op.ZC_MEMBER_EXIT, 0x0079, 29);
			Register(Op.CZ_CHANGE_CHATROOM, 0x007A, -1);
			Register(Op.ZC_CHANGE_CHATROOM, 0x007B, -1);
			Register(Op.CZ_REQ_ROLE_CHANGE, 0x007C, 30);
			Register(Op.ZC_ROLE_CHANGE, 0x007D, 30);
			Register(Op.CZ_REQ_EXPEL_MEMBER, 0x007E, 16);
			Register(Op.CZ_EXIT_ROOM, 0x007F, 2);
			Register(Op.CZ_REQ_EXCHANGE_ITEM, 0x0080, 6);
			Register(Op.ZC_REQ_EXCHANGE_ITEM, 0x0081, 26);
			Register(Op.CZ_ACK_EXCHANGE_ITEM, 0x0082, 3);
			Register(Op.ZC_ACK_EXCHANGE_ITEM, 0x0083, 3);
			Register(Op.CZ_ADD_EXCHANGE_ITEM, 0x0084, 8);
			Register(Op.ZC_ADD_EXCHANGE_ITEM, 0x0085, 30);
			Register(Op.ZC_ACK_ADD_EXCHANGE_ITEM, 0x0086, 5);
			Register(Op.CZ_CONCLUDE_EXCHANGE_ITEM, 0x0087, 2);
			Register(Op.ZC_CONCLUDE_EXCHANGE_ITEM, 0x0088, 3);
			Register(Op.CZ_CANCEL_EXCHANGE_ITEM, 0x0089, 2);
			Register(Op.ZC_CANCEL_EXCHANGE_ITEM, 0x008A, 2);
			Register(Op.CZ_EXEC_EXCHANGE_ITEM, 0x008B, 2);
			Register(Op.ZC_EXEC_EXCHANGE_ITEM, 0x008C, 3);
			Register(Op.ZC_EXCHANGEITEM_UNDO, 0x008D, 2);
			Register(Op.ZC_NOTIFY_STOREITEM_COUNTINFO, 0x008E, 6);
			Register(Op.CZ_MOVE_ITEM_FROM_BODY_TO_STORE, 0x008F, 8);
			Register(Op.ZC_ADD_ITEM_TO_STORE, 0x0090, 32);
			Register(Op.CZ_MOVE_ITEM_FROM_STORE_TO_BODY, 0x0091, 8);
			Register(Op.ZC_DELETE_ITEM_FROM_STORE, 0x0092, 8);
			Register(Op.CZ_CLOSE_STORE, 0x0093, 2);
			Register(Op.ZC_CLOSE_STORE, 0x0094, 2);
			Register(Op.CZ_MAKE_GROUP, 0x0095, 26);
			Register(Op.ZC_ACK_MAKE_GROUP, 0x0096, 3);
			Register(Op.ZC_GROUP_LIST, 0x0097, -1);
			Register(Op.CZ_REQ_JOIN_GROUP, 0x0098, 6);
			Register(Op.ZC_ACK_REQ_JOIN_GROUP, 0x0099, 27);
			Register(Op.ZC_REQ_JOIN_GROUP, 0x009A, 30);
			Register(Op.CZ_JOIN_GROUP, 0x009B, 10);
			Register(Op.CZ_REQ_LEAVE_GROUP, 0x009C, 2);
			Register(Op.ZC_GROUPINFO_CHANGE, 0x009D, 6);
			Register(Op.CZ_CHANGE_GROUPEXPOPTION, 0x009E, 6);
			Register(Op.CZ_REQ_EXPEL_GROUP_MEMBER, 0x009F, 30);
			Register(Op.ZC_ADD_MEMBER_TO_GROUP, 0x00A0, 79);
			Register(Op.ZC_DELETE_MEMBER_FROM_GROUP, 0x00A1, 31);
			Register(Op.ZC_NOTIFY_HP_TO_GROUPM, 0x00A2, 10);
			Register(Op.ZC_NOTIFY_POSITION_TO_GROUPM, 0x00A3, 10);
			Register(Op.CZ_REQUEST_CHAT_PARTY, 0x00A4, -1);
			Register(Op.ZC_NOTIFY_CHAT_PARTY, 0x00A5, -1);
			Register(Op.ZC_MVP_GETTING_ITEM, 0x00A6, 18);
			Register(Op.ZC_MVP_GETTING_SPECIAL_EXP, 0x00A7, 6);
			Register(Op.ZC_MVP, 0x00A8, 6);
			Register(Op.ZC_THROW_MVPITEM, 0x00A9, 2);
			Register(Op.ZC_SKILLINFO_UPDATE, 0x00AA, 9);
			Register(Op.ZC_SKILLINFO_LIST, 0x00AB, -1);
			Register(Op.ZC_ACK_TOUSESKILL, 0x00AC, 6);
			Register(Op.ZC_ADD_SKILL, 0x00AD, 39);

			// Added in Beta
			Register(Op.CZ_UPGRADE_SKILLLEVEL, 0x00AE, 4);
			Register(Op.CZ_USE_SKILL, 0x00AF, 10);
			Register(Op.ZC_NOTIFY_SKILL, 0x00B0, 31);
			Register(Op.ZC_NOTIFY_SKILL_POSITION, 0x00B1, 35);
			Register(Op.CZ_USE_SKILL_TOGROUND, 0x00B2, 10);
			Register(Op.ZC_NOTIFY_GROUNDSKILL, 0x00B3, 18);
			Register(Op.CZ_CANCEL_LOCKON, 0x00B4, 2);
			Register(Op.ZC_STATE_CHANGE, 0x00B5, 13);
			Register(Op.ZC_USE_SKILL, 0x00B6, 15);
			Register(Op.CZ_SELECT_WARPPOINT, 0x00B7, 20);
			Register(Op.ZC_WARPLIST, 0x00B8, 52);
			Register(Op.CZ_REMEMBER_WARPPOINT, 0x00B9, 2);
			Register(Op.ZC_ACK_REMEMBER_WARPPOINT, 0x00BA, 3);
			Register(Op.ZC_SKILL_ENTRY, 0x00BB, 11);
			Register(Op.ZC_SKILL_DISAPPEAR, 0x00BC, 6);
			Register(Op.ZC_NOTIFY_CARTITEM_COUNTINFO, 0x00BD, 14);
			Register(Op.ZC_CART_EQUIPMENT_ITEMLIST, 0x00BE, -1);
			Register(Op.ZC_CART_NORMAL_ITEMLIST, 0x00BF, -1);
			Register(Op.ZC_ADD_ITEM_TO_CART, 0x00C0, 32);
			Register(Op.ZC_DELETE_ITEM_FROM_CART, 0x00C1, 8);
			Register(Op.CZ_MOVE_ITEM_FROM_BODY_TO_CART, 0x00C2, 8);
			Register(Op.CZ_MOVE_ITEM_FROM_CART_TO_BODY, 0x00C3, 8);
			Register(Op.CZ_MOVE_ITEM_FROM_STORE_TO_CART, 0x00C4, 8);
			Register(Op.CZ_MOVE_ITEM_FROM_CART_TO_STORE, 0x00C5, 8);
			Register(Op.CZ_REQ_CARTOFF, 0x00C6, 2);
			Register(Op.ZC_CARTOFF, 0x00C7, 2);
			Register(Op.ZC_ACK_ADDITEM_TO_CART, 0x00C8, 3);
			Register(Op.ZC_OPENSTORE, 0x00C9, 4);
			Register(Op.CZ_REQ_CLOSESTORE, 0x00CA, 2);
			Register(Op.CZ_REQ_OPENSTORE, 0x00CB, -1);
			Register(Op.CZ_REQ_BUY_FROMMC, 0x00CC, 6);
			Register(Op.ZC_STORE_ENTRY, 0x00CD, 86);
			Register(Op.ZC_DISAPPEAR_ENTRY, 0x00CE, 6);
			Register(Op.ZC_PC_PURCHASE_ITEMLIST_FROMMC, 0x00CF, -1);
			Register(Op.CZ_PC_PURCHASE_ITEMLIST_FROMMC, 0x00D0, -1);
			Register(Op.ZC_PC_PURCHASE_RESULT_FROMMC, 0x00D1, 7);
			Register(Op.ZC_PC_PURCHASE_MYITEMLIST, 0x00D2, -1);
			Register(Op.ZC_DELETEITEM_FROM_MCSTORE, 0x00D3, 6);
			Register(Op.CZ_PKMODE_CHANGE, 0x00D4, 3);
			Register(Op.ZC_ATTACK_FAILURE_FOR_DISTANCE, 0x00D5, 16);
			Register(Op.ZC_ATTACK_RANGE, 0x00D6, 4);
			Register(Op.ZC_ACTION_FAILURE, 0x00D7, 4);
			Register(Op.ZC_EQUIP_ARROW, 0x00D8, 4);
			Register(Op.ZC_RECOVERY, 0x00D9, 6);
			Register(Op.ZC_USESKILL_ACK, 0x00DA, 24);
			Register(Op.CZ_ITEM_CREATE, 0x00DB, 26);
			Register(Op.CZ_MOVETO_MAP, 0x00DC, 18); // ?
			///Register(Op.ZC_COUPLESTATUS,0x00DD, 14); // There's a handler for it, but it doesn't appear in the packet table

			RegisterNames();
		}

		/// <summary>
		/// Numeric value indicating a dynamic packet size.
		/// </summary>
		public const int Dynamic = -1;

		private static readonly Dictionary<int, int> Sizes = new Dictionary<int, int>();
		private static readonly Dictionary<int, string> Names = new Dictionary<int, string>();

		/// <summary>
		/// Adds new opcode to table.
		/// </summary>
		/// <param name="identifier"></param>
		/// <param name="op"></param>
		/// <param name="size"></param>
		public static void Register(int identifier, int op, int size)
			=> Register(op, size);

		/// <summary>
		/// Adds new opcode to table.
		/// </summary>
		/// <param name="op"></param>
		/// <param name="size"></param>
		public static void Register(int op, int size)
		{
			Sizes[op] = size;
		}

		/// <summary>
		/// Reads names from opcode list.
		/// </summary>
		private static void RegisterNames()
		{
			foreach (var field in typeof(Op).GetFields(BindingFlags.Public | BindingFlags.Static))
				Names[(int)field.GetValue(null)] = field.Name;
		}

		/// <summary>
		/// Returns the size of packets with the given opcode. If size is
		/// -1 (PacketTable.Dynamic), the packet's size is dynamic.
		/// </summary>
		/// <param name="op"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static int GetSize(int op)
		{
			if (!Sizes.TryGetValue(op, out var size))
				throw new ArgumentException($"No size found for op '{op:X4}'.");

			return size;
		}

		/// <summary>
		/// Returns the name of the given opcode.
		/// </summary>
		/// <param name="op"></param>
		/// <returns></returns>
		public static string GetName(int op)
		{
			if (!Names.TryGetValue(op, out var name))
				return "?";

			return name;
		}
	}
}
