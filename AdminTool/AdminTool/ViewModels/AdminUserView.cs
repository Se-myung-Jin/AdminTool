using System.ComponentModel.DataAnnotations;

namespace AdminTool.ViewModels
{
    public class AdminUserView
    {
        [Required(ErrorMessage = "Please enter your ID.")]
        public string UserID { get; set; }

        [Required(ErrorMessage = "Please enter your Password.")]
        public string UserPassword { get; set; }
    }
}
