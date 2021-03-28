using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTool
{
    public class AdminConst
    {
        public enum Permission
        {
            USER_MANAGER = 1,
            USER_DATA = 2,
            USER_LOG = 3,
            USER_DEVICE = 4,
            GUILD_MANAGER = 5,
            GUILD_DATA = 6,
            GUILD_LOG = 7,
            GUILD_CHAT_LOG = 8,
            EVENT_MANAGER = 9,
            EVENT_BANNER = 10,
            SERVICE_MANAGER = 11,
            NOTICE = 12,
            PUSH = 13,
            SINGLE_MAIL = 14,
            MULTI_MAIL = 15,
            PAYMENT = 16,
            COUPON = 17,
            BLACKLIST = 18,
            SERVER_MANAGER = 19,
            MACHINE_STATUS = 20,
            WHITELIST_USER = 21,
            WHITELIST_IP = 22,
            ADMIN_MANAGER = 100,
            ADMIN_ACCOUNT = 101,
            ADMIN_LOG = 102,
            ADMIN_PERMISSION = 103,
        }
    }
}
