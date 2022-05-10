Protocol Version 100
==============================================================================

Name                                       | Op       | Size
-------------------------------------------|----------|-------
CA_LOGIN                                   | 0x0000   | 34
CH_ENTER                                   | 0x0001   | 13
CH_SELECT_CHAR                             | 0x0002   | 3
CH_MAKE_CHAR                               | 0x0003   | 26
CH_DELETE_CHAR                             | 0x0004   | 6
AC_ACCEPT_LOGIN                            | 0x0005   | -1
AC_REFUSE_LOGIN                            | 0x0006   | 3
HC_ACCEPT_ENTER                            | 0x0007   | -1
HC_REFUSE_ENTER                            | 0x0008   | 3
HC_ACCEPT_MAKECHAR                         | 0x0009   | 76
HC_REFUSE_MAKECHAR                         | 0x000A   | 3
HC_ACCEPT_DELETECHAR                       | 0x000B   | 2
HC_REFUSE_DELETECHAR                       | 0x000C   | 3
HC_NOTIFY_ZONESVR                          | 0x000D   | 28
CZ_ENTER                                   | 0x000E   | 15
ZC_ACCEPT_ENTER                            | 0x000F   | 11
ZC_REFUSE_ENTER                            | 0x0010   | 3
ZC_NOTIFY_INITCHAR                         | 0x0011   | -1
ZC_NOTIFY_UPDATECHAR                       | 0x0012   | 9
ZC_NOTIFY_UPDATEPLAYER                     | 0x0013   | 5
ZC_NOTIFY_STANDENTRY                       | 0x0014   | 19
ZC_NOTIFY_NEWENTRY                         | 0x0015   | 18
ZC_NOTIFY_ACTENTRY                         | 0x0016   | 23
ZC_NOTIFY_MOVEENTRY                        | 0x0017   | 25
ZC_NOTIFY_STANDENTRY_NPC                   | 0x0018   | 18
CZ_NOTIFY_ACTORINIT                        | 0x0019   | 2
CZ_REQUEST_TIME                            | 0x001A   | 2
ZC_NOTIFY_TIME                             | 0x001B   | 6
ZC_NOTIFY_VANISH                           | 0x001C   | 7
SC_NOTIFY_BAN                              | 0x001D   | 3
CZ_REQUEST_QUIT                            | 0x001E   | 2
ZC_ACCEPT_QUIT                             | 0x001F   | 2
ZC_REFUSE_QUIT                             | 0x0020   | 2
CZ_REQUEST_MOVE                            | 0x0021   | 5
ZC_NOTIFY_MOVE                             | 0x0022   | 16
ZC_NOTIFY_PLAYERMOVE                       | 0x0023   | 12
ZC_STOPMOVE                                | 0x0024   | 10
CZ_REQUEST_ACT                             | 0x0025   | 7
ZC_NOTIFY_ACT                              | 0x0026   | 17
CZ_REQUEST_CHAT                            | 0x0027   | -1
ZC_NOTIFY_CHAT                             | 0x0028   | -1
ZC_NOTIFY_PLAYERCHAT                       | 0x0029   | -1
SERVER_ENTRY_ACK                           | 0x002A   | -1
CZ_CONTACTNPC                              | 0x002B   | 7
ZC_NPCACK_MAPMOVE                          | 0x002C   | 22
ZC_NPCACK_SERVERMOVE                       | 0x002D   | 28
ZC_NPCACK_ENABLE                           | 0x002E   | 2
CZ_REQNAME                                 | 0x002F   | 6
ZC_ACK_REQNAME                             | 0x0030   | 38
CZ_WHISPER                                 | 0x0031   | -1
ZC_WHISPER                                 | 0x0032   | -1
ZC_ACK_WHISPER                             | 0x0033   | 3
CZ_BROADCAST                               | 0x0034   | -1
ZC_BROADCAST                               | 0x0035   | -1
CZ_CHANGE_DIRECTION                        | 0x0036   | 3
ZC_CHANGE_DIRECTION                        | 0x0037   | 7
ZC_ITEM_ENTRY                              | 0x0038   | 30
ZC_ITEM_FALL_ENTRY                         | 0x0039   | 30
CZ_ITEM_PICKUP                             | 0x003A   | 6
ZC_ITEM_PICKUP_ACK                         | 0x003B   | 25
ZC_ITEM_DISAPPEAR                          | 0x003C   | 6
CZ_ITEM_THROW                              | 0x003D   | 6
ZC_NORMAL_ITEMLIST                         | 0x003E   | -1
ZC_EQUIPMENT_ITEMLIST                      | 0x003F   | -1
ZC_STORE_NORMAL_ITEMLIST                   | 0x0040   | -1
ZC_STORE_EQUIPMENT_ITEMLIST                | 0x0041   | -1
CZ_USE_ITEM                                | 0x0042   | 8
ZC_USE_ITEM_ACK                            | 0x0043   | 7
CZ_REQ_WEAR_EQUIP                          | 0x0044   | 5
ZC_REQ_WEAR_EQUIP_ACK                      | 0x0045   | 6
CZ_REQ_TAKEOFF_EQUIP                       | 0x0046   | 4
ZC_REQ_TAKEOFF_EQUIP_ACK                   | 0x0047   | 6
CZ_REQ_ITEM_EXPLANATION_BYNAME             | 0x0048   | 18
ZC_REQ_ITEM_EXPLANATION_ACK                | 0x0049   | -1
ZC_ITEM_THROW_ACK                          | 0x004A   | 6
ZC_PAR_CHANGE                              | 0x004B   | 6
ZC_LONGPAR_CHANGE                          | 0x004C   | 8
CZ_RESTART                                 | 0x004D   | 3
ZC_RESTART_ACK                             | 0x004E   | 3
ZC_SAY_DIALOG                              | 0x004F   | -1
ZC_WAIT_DIALOG                             | 0x0050   | 6
ZC_CLOSE_DIALOG                            | 0x0051   | 6
ZC_MENU_LIST                               | 0x0052   | -1
CZ_CHOOSE_MENU                             | 0x0053   | 7
CZ_REQ_NEXT_SCRIPT                         | 0x0054   | 6
CZ_REQ_STATUS                              | 0x0055   | 2
CZ_STATUS_CHANGE                           | 0x0056   | 5
ZC_STATUS_CHANGE_ACK                       | 0x0057   | 6
ZC_STATUS                                  | 0x0058   | 20
ZC_STATUS_CHANGE                           | 0x0059   | 5
CZ_REQ_EMOTION                             | 0x005A   | 3
ZC_EMOTION                                 | 0x005B   | 7
CZ_REQ_USER_COUNT                          | 0x005C   | 2
ZC_USER_COUNT                              | 0x005D   | 6
ZC_SPRITE_CHANGE                           | 0x005E   | 8
ZC_SELECT_DEALTYPE                         | 0x005F   | 6
CZ_ACK_SELECT_DEALTYPE                     | 0x0060   | 7
ZC_PC_PURCHASE_ITEMLIST                    | 0x0061   | -1
ZC_PC_SELL_ITEMLIST                        | 0x0062   | -1
CZ_PC_PURCHASE_ITEMLIST                    | 0x0063   | -1
CZ_PC_SELL_ITEMLIST                        | 0x0064   | -1
ZC_PC_PURCHASE_RESULT                      | 0x0065   | 3
ZC_PC_SELL_RESULT                          | 0x0066   | 3
CZ_DISCONNECT_CHARACTER                    | 0x0067   | 18
ZC_ACK_DISCONNECT_CHARACTER                | 0x0068   | 3
CZ_DISCONNECT_ALL_CHARACTER                | 0x0069   | 2
CZ_SETTING_WHISPER_PC                      | 0x006A   | 19
CZ_SETTING_WHISPER_STATE                   | 0x006B   | 3
ZC_SETTING_WHISPER_PC                      | 0x006C   | 4
ZC_SETTING_WHISPER_STATE                   | 0x006D   | 4
CZ_REQ_WHISPER_LIST                        | 0x006E   | 2
ZC_WHISPER_LIST                            | 0x006F   | -1
CZ_CREATE_CHATROOM                         | 0x0070   | -1
ZC_ACK_CREATE_CHATROOM                     | 0x0071   | 3
ZC_ROOM_NEWENTRY                           | 0x0072   | -1
ZC_DESTROY_ROOM                            | 0x0073   | 6
CZ_REQ_ENTER_ROOM                          | 0x0074   | 14
ZC_REFUSE_ENTER_ROOM                       | 0x0075   | 3
ZC_ENTER_ROOM                              | 0x0076   | -1
ZC_MEMBER_NEWENTRY                         | 0x0077   | 20
ZC_MEMBER_EXIT                             | 0x0078   | 21
CZ_CHANGE_CHATROOM                         | 0x0079   | -1
ZC_CHANGE_CHATROOM                         | 0x007A   | -1
CZ_REQ_ROLE_CHANGE                         | 0x007B   | 22
ZC_ROLE_CHANGE                             | 0x007C   | 22
CZ_REQ_EXPEL_MEMBER                        | 0x007D   | 18
CZ_EXIT_ROOM                               | 0x007E   | 2
CZ_REQ_EXCHANGE_ITEM                       | 0x007F   | 6
ZC_REQ_EXCHANGE_ITEM                       | 0x0080   | 18
CZ_ACK_EXCHANGE_ITEM                       | 0x0081   | 3
ZC_ACK_EXCHANGE_ITEM                       | 0x0082   | 3
CZ_ADD_EXCHANGE_ITEM                       | 0x0083   | 8
ZC_ADD_EXCHANGE_ITEM                       | 0x0084   | 22
ZC_ACK_ADD_EXCHANGE_ITEM                   | 0x0085   | 5
CZ_CONCLUDE_EXCHANGE_ITEM                  | 0x0086   | 2
ZC_CONCLUDE_EXCHANGE_ITEM                  | 0x0087   | 3
CZ_CANCEL_EXCHANGE_ITEM                    | 0x0088   | 2
ZC_CANCEL_EXCHANGE_ITEM                    | 0x0089   | 2
CZ_EXEC_EXCHANGE_ITEM                      | 0x008A   | 2
ZC_EXEC_EXCHANGE_ITEM                      | 0x008B   | 3
ZC_EXCHANGEITEM_UNDO                       | 0x008C   | 2
ZC_NOTIFY_STOREITEM_COUNTINFO              | 0x008D   | 6
CZ_MOVE_ITEM_FROM_BODY_TO_STORE            | 0x008E   | 8
ZC_ADD_ITEM_TO_STORE                       | 0x008F   | 24
CZ_MOVE_ITEM_FROM_STORE_TO_BODY            | 0x0090   | 8
ZC_DELETE_ITEM_FROM_STORE                  | 0x0091   | 8
CZ_CLOSE_STORE                             | 0x0092   | 2
ZC_CLOSE_STORE                             | 0x0093   | 2
CZ_MAKE_GROUP                              | 0x0094   | 22
ZC_ACK_MAKE_GROUP                          | 0x0095   | 3
ZC_GROUP_LIST                              | 0x0096   | -1
CZ_REQ_JOIN_GROUP                          | 0x0097   | 6
ZC_ACK_REQ_JOIN_GROUP                      | 0x0098   | 27
ZC_REQ_JOIN_GROUP                          | 0x0099   | 30
CZ_JOIN_GROUP                              | 0x009A   | 10
CZ_REQ_LEAVE_GROUP                         | 0x009B   | 2
CZ_REQ_EXPEL_GROUP_MEMBER                  | 0x009C   | 30
ZC_ADD_MEMBER_TO_GROUP                     | 0x009D   | 79
ZC_DELETE_MEMBER_FROM_GROUP                | 0x009E   | 31
ZC_NOTIFY_HP_TO_GROUPM                     | 0x009F   | 10
ZC_NOTIFY_POSITION_TO_GROUPM               | 0x00A0   | 10
CZ_REQUEST_CHAT_PARTY                      | 0x00A1   | -1
ZC_NOTIFY_CHAT_PARTY                       | 0x00A2   | -1
ZC_MVP_GETTING_ITEM                        | 0x00A3   | 18
ZC_MVP_GETTING_SPECIAL_EXP                 | 0x00A4   | 6
ZC_MVP                                     | 0x00A5   | 6
ZC_THROW_MVPITEM                           | 0x00A6   | 2
ZC_SKILLINFO_UPDATE                        | 0x00A7   | 9
ZC_SKILLINFO_LIST                          | 0x00A8   | -1
ZC_ACK_TOUSESKILL                          | 0x00A9   | 6
ZC_ADD_SKILL                               | 0x00AA   | 33