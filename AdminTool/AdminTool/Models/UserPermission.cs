using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminTool.Models
{
    public class UserPermission
    {
        /// <summary>
        /// 운영툴 유저 고유 ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 부여 받은 권한 ID
        /// </summary>
        public int Permission_Id { get; set; }
    }
}
