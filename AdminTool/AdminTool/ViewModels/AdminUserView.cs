using System.ComponentModel.DataAnnotations;

namespace AdminTool.ViewModels
{
    public class AdminUserView
    {
        [Required(ErrorMessage = "Please enter your ID.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your Password.")]
        public string Password { get; set; }
    }
}
