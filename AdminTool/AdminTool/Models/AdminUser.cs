using System.ComponentModel.DataAnnotations;

namespace AdminTool.Models
{
    public class AdminUser
    {
        /// <summary>
        /// 사용자 고유 번호
        /// </summary>
        [Key] // Primary Key 설정
        public int Id { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [Required(ErrorMessage = "Please enter your ID.")] // Not Null
        public string Username { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [Required(ErrorMessage = "Please enter your Password.")] // Not Null
        public string Password { get; set; }
    }
}
