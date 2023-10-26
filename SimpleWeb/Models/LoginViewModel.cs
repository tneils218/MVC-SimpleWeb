using System.ComponentModel.DataAnnotations;

namespace SimpleWeb.Models;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email của bạn")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Required]
    [Display(Name = "Mật khẩu")]
    public string Password { get; set; }
    [Display(Name = "Nhớ tài khoản")]

    public bool RememberMe { get; set; }
}