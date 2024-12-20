using System.ComponentModel.DataAnnotations;

namespace Resume.DAL.ViewModels
{
    public class CreateUserViewModel
    {
        [Display(Name ="نام")]
        [Required(ErrorMessage ="لطفا {} را وارد کنید")]
        [MaxLength(150,ErrorMessage ="تعداد کاراکتر وارد شده سحیح نمی باشد")]
        public string FirstName { get; set; }
        
        [Display(Name = " نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "تعداد کاراکتر وارد شده سحیح نمی باشد")]
        public string LastName { get; set; }
        
        [Display(Name = "موبایل")]
        [Required(ErrorMessage = "لطفا {} را وارد کنید")]
        [MaxLength(15, ErrorMessage = "تعداد کاراکتر وارد شده سحیح نمی باشد")]
        public string Mobile { get; set; }
        
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {} را وارد کنید")]
        [MaxLength(350, ErrorMessage = "تعداد کاراکتر وارد شده سحیح نمی باشد")]
        public string Email { get; set; }
        
        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "لطفا {} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "تعداد کاراکتر وارد شده سحیح نمی باشد")]
        public string Password { get; set; }
        
        [Display(Name = "فعال / غیر فعال")]
        public bool IsActive { get; set; }
    }
    public enum CreateUserResult
    {
        Success, Error
    }
}
