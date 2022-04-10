﻿namespace Sabine.Shared.Network
{
	public static class Op
	{
		public const int CA_LOGIN = 0x0000;
		public const int CH_ENTER = 0x0001;
		public const int CH_SELECT_CHAR = 0x0002;
		public const int CH_MAKE_CHAR = 0x0003;
		public const int CH_DELETE_CHAR = 0x0004;
		public const int AC_ACCEPT_LOGIN = 0x0005;
		public const int AC_REFUSE_LOGIN = 0x0006;
		public const int HC_ACCEPT_ENTER = 0x0007;
		public const int HC_REFUSE_ENTER = 0x0008;
		public const int HC_ACCEPT_MAKECHAR = 0x0009;
		public const int HC_REFUSE_MAKECHAR = 0x000A;
		public const int HC_ACCEPT_DELETECHAR = 0x000B;
		public const int HC_REFUSE_DELETECHAR = 0x000C;
		public const int HC_NOTIFY_ZONESVR = 0x000D;
		public const int CZ_ENTER = 0x000E;
		public const int ZC_ACCEPT_ENTER = 0x000F;
		public const int ZC_REFUSE_ENTER = 0x0010;
		public const int ZC_NOTIFY_INITCHAR = 0x0011;
		public const int ZC_NOTIFY_UPDATECHAR = 0x0012;
		public const int ZC_NOTIFY_UPDATEPLAYER = 0x0013;
		public const int ZC_NOTIFY_STANDENTRY = 0x0014;
		public const int ZC_NOTIFY_NEWENTRY = 0x0015;
		public const int ZC_NOTIFY_ACTENTRY = 0x0016;
		public const int ZC_NOTIFY_MOVEENTRY = 0x0017;
		public const int ZC_NOTIFY_STANDENTRY_NPC = 0x0018;
		public const int CZ_NOTIFY_ACTORINIT = 0x0019;
		public const int CZ_REQUEST_TIME = 0x001A;
		public const int ZC_NOTIFY_TIME = 0x001B;
		public const int ZC_NOTIFY_VANISH = 0x001C;
		public const int SC_NOTIFY_BAN = 0x001D;
		public const int CZ_REQUEST_QUIT = 0x001E;
		public const int ZC_ACCEPT_QUIT = 0x001F;
		public const int ZC_REFUSE_QUIT = 0x0020;
		public const int CZ_REQUEST_MOVE = 0x0021;
		public const int ZC_NOTIFY_MOVE = 0x0022;
		public const int ZC_NOTIFY_PLAYERMOVE = 0x0023;
		public const int ZC_STOPMOVE = 0x0024;
		public const int CZ_REQUEST_ACT = 0x0025; // Guessed
		public const int ZC_NOTIFY_ACT = 0x0026; // Guessed
		///public const int ZC_NOTIFY_ACT_POSITION = 0x0027; // Seems to be missing, shifting the following ops
		public const int CZ_REQUEST_CHAT = 0x0027;
		public const int ZC_NOTIFY_CHAT = 0x0028;
		public const int ZC_NOTIFY_PLAYERCHAT = 0x0029;
		//public const int SERVER_ENTRY_ACK = 0x002A; // Not in client's packet table
		public const int CZ_CONTACTNPC = 0x002B;
		public const int ZC_NPCACK_MAPMOVE = 0x002C;
		public const int ZC_NPCACK_SERVERMOVE = 0x002D;
		public const int ZC_NPCACK_ENABLE = 0x002E;
		public const int CZ_REQNAME = 0x002F;
		public const int ZC_ACK_REQNAME = 0x0030;
		public const int CZ_WHISPER = 0x0031;
		public const int ZC_WHISPER = 0x0032;
		public const int ZC_ACK_WHISPER = 0x0033;
		public const int CZ_BROADCAST = 0x0034;
		public const int ZC_BROADCAST = 0x0035;
		public const int CZ_CHANGE_DIRECTION = 0x0036;
		public const int ZC_CHANGE_DIRECTION = 0x0037;
		public const int ZC_ITEM_ENTRY = 0x0038;
		public const int ZC_ITEM_FALL_ENTRY = 0x0039;
		public const int CZ_ITEM_PICKUP = 0x003A;
		public const int ZC_ITEM_PICKUP_ACK = 0x003B;
		public const int ZC_ITEM_DISAPPEAR = 0x003C;
		public const int CZ_ITEM_THROW = 0x003D;
		public const int ZC_NORMAL_ITEMLIST = 0x003E;
		public const int ZC_EQUIPMENT_ITEMLIST = 0x003F;
		public const int ZC_STORE_NORMAL_ITEMLIST = 0x0040;
		public const int ZC_STORE_EQUIPMENT_ITEMLIST = 0x0041;
		public const int CZ_USE_ITEM = 0x0042;
		public const int ZC_USE_ITEM_ACK = 0x0043;
		public const int CZ_REQ_WEAR_EQUIP = 0x0044;
		public const int ZC_REQ_WEAR_EQUIP_ACK = 0x0045;
		public const int CZ_REQ_TAKEOFF_EQUIP = 0x0046;
		public const int ZC_REQ_TAKEOFF_EQUIP_ACK = 0x0047;
		public const int CZ_REQ_ITEM_EXPLANATION_BYNAME = 0x0048;
		public const int ZC_REQ_ITEM_EXPLANATION_ACK = 0x0049;
		public const int ZC_ITEM_THROW_ACK = 0x004A;
		public const int ZC_PAR_CHANGE = 0x004B;
		public const int ZC_LONGPAR_CHANGE = 0x004C;

		public const int CZ_STATUS_CHANGE = 0x0056;
		public const int ZC_STATUS_CHANGE_ACK = 0x0057;
		public const int ZC_STATUS = 0x0058;
		public const int ZC_STATUS_CHANGE = 0x0059;
		public const int CZ_REQ_EMOTION = 0x005A;
		public const int ZC_EMOTION = 0x005B;
		public const int CZ_REQ_USER_COUNT = 0x005C;
		public const int ZC_USER_COUNT = 0x005D;
		public const int ZC_SPRITE_CHANGE = 0x005E;
	}
}
