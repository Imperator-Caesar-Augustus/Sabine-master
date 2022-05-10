Protocol Version 400
==============================================================================

Name                                       | Op       | Size
-------------------------------------------|----------|-------
CA_LOGIN                                   | 0x0064   | 55
CH_ENTER                                   | 0x0065   | 17
CH_SELECT_CHAR                             | 0x0066   | 3
CH_MAKE_CHAR                               | 0x0067   | 37
CH_DELETE_CHAR                             | 0x0068   | 46
AC_ACCEPT_LOGIN                            | 0x0069   | -1
AC_REFUSE_LOGIN                            | 0x006A   | 23
HC_ACCEPT_ENTER                            | 0x006B   | -1
HC_REFUSE_ENTER                            | 0x006C   | 3
HC_ACCEPT_MAKECHAR                         | 0x006D   | 108
HC_REFUSE_MAKECHAR                         | 0x006E   | 3
HC_ACCEPT_DELETECHAR                       | 0x006F   | 2
HC_REFUSE_DELETECHAR                       | 0x0070   | 3
HC_NOTIFY_ZONESVR                          | 0x0071   | 28
CZ_ENTER                                   | 0x0072   | 19
ZC_ACCEPT_ENTER                            | 0x0073   | 11
ZC_REFUSE_ENTER                            | 0x0074   | 3
ZC_NOTIFY_INITCHAR                         | 0x0075   | -1
ZC_NOTIFY_UPDATECHAR                       | 0x0076   | 9
ZC_NOTIFY_UPDATEPLAYER                     | 0x0077   | 5
ZC_NOTIFY_STANDENTRY                       | 0x0078   | 52
ZC_NOTIFY_NEWENTRY                         | 0x0079   | 51
ZC_NOTIFY_ACTENTRY                         | 0x007A   | 56
ZC_NOTIFY_MOVEENTRY                        | 0x007B   | 58
ZC_NOTIFY_STANDENTRY_NPC                   | 0x007C   | 41
CZ_NOTIFY_ACTORINIT                        | 0x007D   | 2
CZ_REQUEST_TIME                            | 0x007E   | 6
ZC_NOTIFY_TIME                             | 0x007F   | 6
ZC_NOTIFY_VANISH                           | 0x0080   | 7
SC_NOTIFY_BAN                              | 0x0081   | 3
CZ_REQUEST_QUIT                            | 0x0082   | 2
ZC_ACCEPT_QUIT                             | 0x0083   | 2
ZC_REFUSE_QUIT                             | 0x0084   | 2
CZ_REQUEST_MOVE                            | 0x0085   | 5
ZC_NOTIFY_MOVE                             | 0x0086   | 16
ZC_NOTIFY_PLAYERMOVE                       | 0x0087   | 12
ZC_STOPMOVE                                | 0x0088   | 10
CZ_REQUEST_ACT                             | 0x0089   | 7
ZC_NOTIFY_ACT                              | 0x008A   | 29
ZC_NOTIFY_ACT_POSITION                     | 0x008B   | 23
CZ_REQUEST_CHAT                            | 0x008C   | -1
ZC_NOTIFY_CHAT                             | 0x008D   | -1
ZC_NOTIFY_PLAYERCHAT                       | 0x008E   | -1
SERVER_ENTRY_ACK                           | 0x008F   | -1
CZ_CONTACTNPC                              | 0x0090   | 7
ZC_NPCACK_MAPMOVE                          | 0x0091   | 22
ZC_NPCACK_SERVERMOVE                       | 0x0092   | 28
ZC_NPCACK_ENABLE                           | 0x0093   | 2
CZ_REQNAME                                 | 0x0094   | 6
ZC_ACK_REQNAME                             | 0x0095   | 30
CZ_WHISPER                                 | 0x0096   | -1
ZC_WHISPER                                 | 0x0097   | -1
ZC_ACK_WHISPER                             | 0x0098   | 3
CZ_BROADCAST                               | 0x0099   | -1
ZC_BROADCAST                               | 0x009A   | -1
CZ_CHANGE_DIRECTION                        | 0x009B   | 5
ZC_CHANGE_DIRECTION                        | 0x009C   | 9
ZC_ITEM_ENTRY                              | 0x009D   | 17
ZC_ITEM_FALL_ENTRY                         | 0x009E   | 17
CZ_ITEM_PICKUP                             | 0x009F   | 6
ZC_ITEM_PICKUP_ACK                         | 0x00A0   | 23
ZC_ITEM_DISAPPEAR                          | 0x00A1   | 6
CZ_ITEM_THROW                              | 0x00A2   | 6
ZC_NORMAL_ITEMLIST                         | 0x00A3   | -1
ZC_EQUIPMENT_ITEMLIST                      | 0x00A4   | -1
ZC_STORE_NORMAL_ITEMLIST                   | 0x00A5   | -1
ZC_STORE_EQUIPMENT_ITEMLIST                | 0x00A6   | -1
CZ_USE_ITEM                                | 0x00A7   | 8
ZC_USE_ITEM_ACK                            | 0x00A8   | 7
CZ_REQ_WEAR_EQUIP                          | 0x00A9   | 6
ZC_REQ_WEAR_EQUIP_ACK                      | 0x00AA   | 7
CZ_REQ_TAKEOFF_EQUIP                       | 0x00AB   | 4
ZC_REQ_TAKEOFF_EQUIP_ACK                   | 0x00AC   | 7
CZ_REQ_ITEM_EXPLANATION_BYNAME             | 0x00AD   | 26
ZC_REQ_ITEM_EXPLANATION_ACK                | 0x00AE   | -1
ZC_ITEM_THROW_ACK                          | 0x00AF   | 6
ZC_PAR_CHANGE                              | 0x00B0   | 8
ZC_LONGPAR_CHANGE                          | 0x00B1   | 8
CZ_RESTART                                 | 0x00B2   | 3
ZC_RESTART_ACK                             | 0x00B3   | 3
ZC_SAY_DIALOG                              | 0x00B4   | -1
ZC_WAIT_DIALOG                             | 0x00B5   | 6
ZC_CLOSE_DIALOG                            | 0x00B6   | 6
ZC_MENU_LIST                               | 0x00B7   | -1
CZ_CHOOSE_MENU                             | 0x00B8   | 7
CZ_REQ_NEXT_SCRIPT                         | 0x00B9   | 6
CZ_REQ_STATUS                              | 0x00BA   | 2
CZ_STATUS_CHANGE                           | 0x00BB   | 5
ZC_STATUS_CHANGE_ACK                       | 0x00BC   | 6
ZC_STATUS                                  | 0x00BD   | 44
ZC_STATUS_CHANGE                           | 0x00BE   | 5
CZ_REQ_EMOTION                             | 0x00BF   | 3
ZC_EMOTION                                 | 0x00C0   | 7
CZ_REQ_USER_COUNT                          | 0x00C1   | 2
ZC_USER_COUNT                              | 0x00C2   | 6
ZC_SPRITE_CHANGE                           | 0x00C3   | 8
ZC_SELECT_DEALTYPE                         | 0x00C4   | 6
CZ_ACK_SELECT_DEALTYPE                     | 0x00C5   | 7
ZC_PC_PURCHASE_ITEMLIST                    | 0x00C6   | -1
ZC_PC_SELL_ITEMLIST                        | 0x00C7   | -1
CZ_PC_PURCHASE_ITEMLIST                    | 0x00C8   | -1
CZ_PC_SELL_ITEMLIST                        | 0x00C9   | -1
ZC_PC_PURCHASE_RESULT                      | 0x00CA   | 3
ZC_PC_SELL_RESULT                          | 0x00CB   | 3
CZ_DISCONNECT_CHARACTER                    | 0x00CC   | 6
ZC_ACK_DISCONNECT_CHARACTER                | 0x00CD   | 3
CZ_DISCONNECT_ALL_CHARACTER                | 0x00CE   | 2
CZ_SETTING_WHISPER_PC                      | 0x00CF   | 27
CZ_SETTING_WHISPER_STATE                   | 0x00D0   | 3
ZC_SETTING_WHISPER_PC                      | 0x00D1   | 4
ZC_SETTING_WHISPER_STATE                   | 0x00D2   | 4
CZ_REQ_WHISPER_LIST                        | 0x00D3   | 2
ZC_WHISPER_LIST                            | 0x00D4   | -1
CZ_CREATE_CHATROOM                         | 0x00D5   | -1
ZC_ACK_CREATE_CHATROOM                     | 0x00D6   | 3
ZC_ROOM_NEWENTRY                           | 0x00D7   | -1
ZC_DESTROY_ROOM                            | 0x00D8   | 6
CZ_REQ_ENTER_ROOM                          | 0x00D9   | 14
ZC_REFUSE_ENTER_ROOM                       | 0x00DA   | 3
ZC_ENTER_ROOM                              | 0x00DB   | -1
ZC_MEMBER_NEWENTRY                         | 0x00DC   | 28
ZC_MEMBER_EXIT                             | 0x00DD   | 29
CZ_CHANGE_CHATROOM                         | 0x00DE   | -1
ZC_CHANGE_CHATROOM                         | 0x00DF   | -1
CZ_REQ_ROLE_CHANGE                         | 0x00E0   | 30
ZC_ROLE_CHANGE                             | 0x00E1   | 30
CZ_REQ_EXPEL_MEMBER                        | 0x00E2   | 26
CZ_EXIT_ROOM                               | 0x00E3   | 2
CZ_REQ_EXCHANGE_ITEM                       | 0x00E4   | 6
ZC_REQ_EXCHANGE_ITEM                       | 0x00E5   | 26
CZ_ACK_EXCHANGE_ITEM                       | 0x00E6   | 3
ZC_ACK_EXCHANGE_ITEM                       | 0x00E7   | 3
CZ_ADD_EXCHANGE_ITEM                       | 0x00E8   | 8
ZC_ADD_EXCHANGE_ITEM                       | 0x00E9   | 19
ZC_ACK_ADD_EXCHANGE_ITEM                   | 0x00EA   | 5
CZ_CONCLUDE_EXCHANGE_ITEM                  | 0x00EB   | 2
ZC_CONCLUDE_EXCHANGE_ITEM                  | 0x00EC   | 3
CZ_CANCEL_EXCHANGE_ITEM                    | 0x00ED   | 2
ZC_CANCEL_EXCHANGE_ITEM                    | 0x00EE   | 2
CZ_EXEC_EXCHANGE_ITEM                      | 0x00EF   | 2
ZC_EXEC_EXCHANGE_ITEM                      | 0x00F0   | 3
ZC_EXCHANGEITEM_UNDO                       | 0x00F1   | 2
ZC_NOTIFY_STOREITEM_COUNTINFO              | 0x00F2   | 6
CZ_MOVE_ITEM_FROM_BODY_TO_STORE            | 0x00F3   | 8
ZC_ADD_ITEM_TO_STORE                       | 0x00F4   | 21
CZ_MOVE_ITEM_FROM_STORE_TO_BODY            | 0x00F5   | 8
ZC_DELETE_ITEM_FROM_STORE                  | 0x00F6   | 8
CZ_CLOSE_STORE                             | 0x00F7   | 2
ZC_CLOSE_STORE                             | 0x00F8   | 2
CZ_MAKE_GROUP                              | 0x00F9   | 26
ZC_ACK_MAKE_GROUP                          | 0x00FA   | 3
ZC_GROUP_LIST                              | 0x00FB   | -1
CZ_REQ_JOIN_GROUP                          | 0x00FC   | 6
ZC_ACK_REQ_JOIN_GROUP                      | 0x00FD   | 27
ZC_REQ_JOIN_GROUP                          | 0x00FE   | 30
CZ_JOIN_GROUP                              | 0x00FF   | 10
CZ_REQ_LEAVE_GROUP                         | 0x0100   | 2
ZC_GROUPINFO_CHANGE                        | 0x0101   | 6
CZ_CHANGE_GROUPEXPOPTION                   | 0x0102   | 6
CZ_REQ_EXPEL_GROUP_MEMBER                  | 0x0103   | 30
ZC_ADD_MEMBER_TO_GROUP                     | 0x0104   | 79
ZC_DELETE_MEMBER_FROM_GROUP                | 0x0105   | 31
ZC_NOTIFY_HP_TO_GROUPM                     | 0x0106   | 10
ZC_NOTIFY_POSITION_TO_GROUPM               | 0x0107   | 10
CZ_REQUEST_CHAT_PARTY                      | 0x0108   | -1
ZC_NOTIFY_CHAT_PARTY                       | 0x0109   | -1
ZC_MVP_GETTING_ITEM                        | 0x010A   | 4
ZC_MVP_GETTING_SPECIAL_EXP                 | 0x010B   | 6
ZC_MVP                                     | 0x010C   | 6
ZC_THROW_MVPITEM                           | 0x010D   | 2
ZC_SKILLINFO_UPDATE                        | 0x010E   | 11
ZC_SKILLINFO_LIST                          | 0x010F   | -1
ZC_ACK_TOUSESKILL                          | 0x0110   | 10
ZC_ADD_SKILL                               | 0x0111   | 39
CZ_UPGRADE_SKILLLEVEL                      | 0x0112   | 4
CZ_USE_SKILL                               | 0x0113   | 10
ZC_NOTIFY_SKILL                            | 0x0114   | 31
ZC_NOTIFY_SKILL_POSITION                   | 0x0115   | 35
CZ_USE_SKILL_TOGROUND                      | 0x0116   | 10
ZC_NOTIFY_GROUNDSKILL                      | 0x0117   | 18
CZ_CANCEL_LOCKON                           | 0x0118   | 2
ZC_STATE_CHANGE                            | 0x0119   | 13
ZC_USE_SKILL                               | 0x011A   | 15
CZ_SELECT_WARPPOINT                        | 0x011B   | 20
ZC_WARPLIST                                | 0x011C   | 68
CZ_REMEMBER_WARPPOINT                      | 0x011D   | 2
ZC_ACK_REMEMBER_WARPPOINT                  | 0x011E   | 3
ZC_SKILL_ENTRY                             | 0x011F   | 16
ZC_SKILL_DISAPPEAR                         | 0x0120   | 6
ZC_NOTIFY_CARTITEM_COUNTINFO               | 0x0121   | 14
ZC_CART_EQUIPMENT_ITEMLIST                 | 0x0122   | -1
ZC_CART_NORMAL_ITEMLIST                    | 0x0123   | -1
ZC_ADD_ITEM_TO_CART                        | 0x0124   | 21
ZC_DELETE_ITEM_FROM_CART                   | 0x0125   | 8
CZ_MOVE_ITEM_FROM_BODY_TO_CART             | 0x0126   | 8
CZ_MOVE_ITEM_FROM_CART_TO_BODY             | 0x0127   | 8
CZ_MOVE_ITEM_FROM_STORE_TO_CART            | 0x0128   | 8
CZ_MOVE_ITEM_FROM_CART_TO_STORE            | 0x0129   | 8
CZ_REQ_CARTOFF                             | 0x012A   | 2
ZC_CARTOFF                                 | 0x012B   | 2
ZC_ACK_ADDITEM_TO_CART                     | 0x012C   | 3
ZC_OPENSTORE                               | 0x012D   | 4
CZ_REQ_CLOSESTORE                          | 0x012E   | 2
CZ_REQ_OPENSTORE                           | 0x012F   | -1
CZ_REQ_BUY_FROMMC                          | 0x0130   | 6
ZC_STORE_ENTRY                             | 0x0131   | 86
ZC_DISAPPEAR_ENTRY                         | 0x0132   | 6
ZC_PC_PURCHASE_ITEMLIST_FROMMC             | 0x0133   | -1
CZ_PC_PURCHASE_ITEMLIST_FROMMC             | 0x0134   | -1
ZC_PC_PURCHASE_RESULT_FROMMC               | 0x0135   | 7
ZC_PC_PURCHASE_MYITEMLIST                  | 0x0136   | -1
ZC_DELETEITEM_FROM_MCSTORE                 | 0x0137   | 6
CZ_PKMODE_CHANGE                           | 0x0138   | 3
ZC_ATTACK_FAILURE_FOR_DISTANCE             | 0x0139   | 16
ZC_ATTACK_RANGE                            | 0x013A   | 4
ZC_ACTION_FAILURE                          | 0x013B   | 4
ZC_EQUIP_ARROW                             | 0x013C   | 4
ZC_RECOVERY                                | 0x013D   | 6
ZC_USESKILL_ACK                            | 0x013E   | 24
CZ_ITEM_CREATE                             | 0x013F   | 26
CZ_MOVETO_MAP                              | 0x0140   | 22
ZC_COUPLESTATUS                            | 0x0141   | 14
ZC_OPEN_EDITDLG                            | 0x0142   | 6
CZ_INPUT_EDITDLG                           | 0x0143   | 10
ZC_COMPASS                                 | 0x0144   | 23
ZC_SHOW_IMAGE                              | 0x0145   | 19
CZ_CLOSE_DIALOG                            | 0x0146   | 6
ZC_AUTORUN_SKILL                           | 0x0147   | 39
ZC_RESURRECTION                            | 0x0148   | 8
CZ_REQ_GIVE_MANNER_POINT                   | 0x0149   | 9
ZC_ACK_GIVE_MANNER_POINT                   | 0x014A   | 6
ZC_NOTIFY_MANNER_POINT_GIVEN               | 0x014B   | 27
ZC_MYGUILD_BASIC_INFO                      | 0x014C   | -1
CZ_REQ_GUILD_MENUINTERFACE                 | 0x014D   | 2
ZC_ACK_GUILD_MENUINTERFACE                 | 0x014E   | 6
CZ_REQ_GUILD_MENU                          | 0x014F   | 6
ZC_GUILD_INFO                              | 0x0150   | 110
CZ_REQ_GUILD_EMBLEM_IMG                    | 0x0151   | 6
ZC_GUILD_EMBLEM_IMG                        | 0x0152   | -1
CZ_REGISTER_GUILD_EMBLEM_IMG               | 0x0153   | -1
ZC_MEMBERMGR_INFO                          | 0x0154   | -1
CZ_REQ_CHANGE_MEMBERPOS                    | 0x0155   | -1
ZC_ACK_REQ_CHANGE_MEMBERS                  | 0x0156   | -1
CZ_REQ_OPEN_MEMBER_INFO                    | 0x0157   | 6
ZC_ACK_OPEN_MEMBER_INFO                    | 0x0158   | -1
CZ_REQ_LEAVE_GUILD                         | 0x0159   | 54
ZC_ACK_LEAVE_GUILD                         | 0x015A   | 66
CZ_REQ_BAN_GUILD                           | 0x015B   | 54
ZC_ACK_BAN_GUILD                           | 0x015C   | 90
CZ_REQ_DISORGANIZE_GUILD                   | 0x015D   | 42
ZC_ACK_DISORGANIZE_GUILD_RESULT            | 0x015E   | 6
ZC_ACK_DISORGANIZE_GUILD                   | 0x015F   | 42
ZC_POSITION_INFO                           | 0x0160   | -1
CZ_REG_CHANGE_GUILD_POSITIONINFO           | 0x0161   | -1
ZC_GUILD_SKILLINFO                         | 0x0162   | -1
ZC_BAN_LIST                                | 0x0163   | -1
ZC_OTHER_GUILD_LIST                        | 0x0164   | -1
CZ_REQ_MAKE_GUILD                          | 0x0165   | 30
ZC_POSITION_ID_NAME_INFO                   | 0x0166   | -1
ZC_RESULT_MAKE_GUILD                       | 0x0167   | 3
CZ_REQ_JOIN_GUILD                          | 0x0168   | 14
ZC_ACK_REQ_JOIN_GUILD                      | 0x0169   | 3
ZC_REQ_JOIN_GUILD                          | 0x016A   | 30
CZ_JOIN_GUILD                              | 0x016B   | 10
ZC_UPDATE_GDID                             | 0x016C   | 43
ZC_UPDATE_CHARSTAT                         | 0x016D   | 14
CZ_GUILD_NOTICE                            | 0x016E   | 186
ZC_GUILD_NOTICE                            | 0x016F   | 182
CZ_REQ_ALLY_GUILD                          | 0x0170   | 14
ZC_REQ_ALLY_GUILD                          | 0x0171   | 30
CZ_ALLY_GUILD                              | 0x0172   | 10
ZC_ACK_REQ_ALLY_GUILD                      | 0x0173   | 3
ZC_ACK_CHANGE_GUILD_POSITIONINFO           | 0x0174   | -1
CZ_REQ_GUILD_MEMBER_INFO                   | 0x0175   | 6
ZC_ACK_GUILD_MEMBER_INFO                   | 0x0176   | 106
ZC_ITEMIDENTIFY_LIST                       | 0x0177   | -1
CZ_REQ_ITEMIDENTIFY                        | 0x0178   | 4
ZC_ACK_ITEMIDENTIFY                        | 0x0179   | 5
CZ_REQ_ITEMCOMPOSITION_LIST                | 0x017A   | 4
ZC_ITEMCOMPOSITION_LIST                    | 0x017B   | -1
CZ_REQ_ITEMCOMPOSITION                     | 0x017C   | 6
ZC_ACK_ITEMCOMPOSITION                     | 0x017D   | 7
CZ_GUILD_CHAT                              | 0x017E   | -1
ZC_GUILD_CHAT                              | 0x017F   | -1
CZ_REQ_HOSTILE_GUILD                       | 0x0180   | 6
ZC_ACK_REQ_HOSTILE_GUILD                   | 0x0181   | 3
ZC_MEMBER_ADD                              | 0x0182   | 106
CZ_REQ_DELETE_RELATED_GUILD                | 0x0183   | 10
ZC_DELETE_RELATED_GUILD                    | 0x0184   | 10
ZC_ADD_RELATED_GUILD                       | 0x0185   | 34
COLLECTORDEAD                              | 0x0186   | -1
PING                                       | 0x0187   | 6
ZC_ACK_ITEMREFINING                        | 0x0188   | 8
ZC_NOTIFY_MAPINFO                          | 0x0189   | 4
CZ_REQ_DISCONNECT                          | 0x018A   | 4
ZC_ACK_REQ_DISCONNECT                      | 0x018B   | 4
ZC_MONSTER_INFO                            | 0x018C   | 29
ZC_MAKABLEITEMLIST                         | 0x018D   | -1
CZ_REQMAKINGITEM                           | 0x018E   | 10
ZC_ACK_REQMAKINGITEM                       | 0x018F   | 6
CZ_USE_SKILL_TOGROUND_WITHTALKBOX          | 0x0190   | 90
ZC_TALKBOX_CHATCONTENTS                    | 0x0191   | 86
ZC_UPDATE_MAPINFO                          | 0x0192   | 24
CZ_REQNAME_BYGID                           | 0x0193   | 6
ZC_ACK_REQNAME_BYGID                       | 0x0194   | 30
ZC_ACK_REQNAMEALL                          | 0x0195   | 102
ZC_MSG_STATE_CHANGE                        | 0x0196   | 9
CZ_RESET                                   | 0x0197   | 4
CZ_CHANGE_MAPTYPE                          | 0x0198   | 8
ZC_NOTIFY_MAPPROPERTY                      | 0x0199   | 4
ZC_NOTIFY_RANKING                          | 0x019A   | 14
ZC_NOTIFY_EFFECT                           | 0x019B   | 10
CZ_LOCALBROADCAST                          | 0x019C   | 4
CZ_CHANGE_EFFECTSTATE                      | 0x019D   | 6
ZC_START_CAPTURE                           | 0x019E   | 2
CZ_TRYCAPTURE_MONSTER                      | 0x019F   | 6
ZC_TRYCAPTURE_MONSTER                      | 0x01A0   | 3
CZ_COMMAND_PET                             | 0x01A1   | 3
ZC_PROPERTY_PET                            | 0x01A2   | 35
ZC_FEED_PET                                | 0x01A3   | 5
ZC_CHANGESTATE_PET                         | 0x01A4   | 11
CZ_RENAME_PET                              | 0x01A5   | 26
ZC_PETEGG_LIST                             | 0x01A6   | -1
CZ_SELECT_PETEGG                           | 0x01A7   | 4
CZ_PETEGG_INFO                             | 0x01A8   | 4
CZ_PET_ACT                                 | 0x01A9   | 6
ZC_PET_ACT                                 | 0x01AA   | 10
ZC_PAR_CHANGE_USER                         | 0x01AB   | 12
ZC_SKILL_UPDATE                            | 0x01AC   | 6
ZC_MAKINGARROW_LIST                        | 0x01AD   | -1
CZ_REQ_MAKINGARROW                         | 0x01AE   | 4
CZ_REQ_CHANGECART                          | 0x01AF   | 4
ZC_NPCSPRITE_CHANGE                        | 0x01B0   | 11
ZC_SHOWDIGIT                               | 0x01B1   | 7
CZ_REQ_OPENSTORE2                          | 0x01B2   | -1
ZC_SHOW_IMAGE2                             | 0x01B3   | 67
ZC_CHANGE_GUILD                            | 0x01B4   | 12
SC_BILLING_INFO                            | 0x01B5   | 18
ZC_GUILD_INFO2                             | 0x01B6   | 114
CZ_GUILD_ZENY                              | 0x01B7   | 6
ZC_GUILD_ZENY_ACK                          | 0x01B8   | 3
ZC_DISPEL                                  | 0x01B9   | 6
CZ_REMOVE_AID                              | 0x01BA   | 26
CZ_SHIFT                                   | 0x01BB   | 26
CZ_RECALL                                  | 0x01BC   | 26
CZ_RECALL_GID                              | 0x01BD   | 26
AC_ASK_PNGAMEROOM                          | 0x01BE   | 2
CA_REPLY_PNGAMEROOM                        | 0x01BF   | 3
CZ_REQ_REMAINTIME                          | 0x01C0   | 2
ZC_REPLY_REMAINTIME                        | 0x01C1   | 14
ZC_INFO_REMAINTIME                         | 0x01C2   | 10
ZC_BROADCAST2                              | 0x01C3   | -1
ZC_ADD_ITEM_TO_STORE2                      | 0x01C4   | 22
ZC_ADD_ITEM_TO_CART2                       | 0x01C5   | 22
CS_REQ_ENCRYPTION                          | 0x01C6   | 4
SC_ACK_ENCRYPTION                          | 0x01C7   | 2
ZC_USE_ITEM_ACK2                           | 0x01C8   | 13
ZC_SKILL_ENTRY2                            | 0x01C9   | 97
CZ_MONSTER_TALK                            | 0x01CB   | 9
ZC_MONSTER_TALK                            | 0x01CC   | 9