using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using THUC_HANH_1.Models;


namespace THUC_HANH_1.Models
{
    public class Student
    {
        public int Id { get; set; }


        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải dài hơn 4 kí tự và không quá 100 kí tự")]
        [Required(ErrorMessage = "Chưa nhập tên")]
        [Display(Name = "Nhập họ tên")]
        public string? Name { get; set; }



        [Required(ErrorMessage = "Email bắt buộc phải được nhập ")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z_0-9]{0,4}gmail.com", ErrorMessage = "Email phải có gmail.com")]
        public string? Email { get; set; }

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải dài từ 8 - 100")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Mật khẩu từ 8 ký tự trở lên, có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt ")]
        [Required(ErrorMessage = "Nhập mật khẩu")]
        [Display(Name = "Mật khẩu")]
        public string? Password { get; set; }
        [Display(Name = "Ngành")]

        [Required(ErrorMessage = "Chưa chọn ngành ")]

        public Branch? Branch { get; set; }
        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Chưa chọn giới tính ")]
       
        public Gender? Gender { get; set; }

  
        [Display(Name = "Loại thường")]
        [Required(ErrorMessage = "Bạn muốn chọn loại không ?")]
        public bool IsRegular { get; set; }

        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText, ErrorMessage = "Chưa nhập địa chỉ")]
        
        public string? Address { get; set; }


        [Required(ErrorMessage = "Chưa chọn ngày sinh ")]
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh phải trong khoảng 1/1/1963 đến 12/31/2005 ")]
        [DataType(DataType.Date)]
        [Display (Name = "Ngày sinh")]
        public DateTime? DateOfBorth { get; set; }

      
        [Required(ErrorMessage = "Chưa nhập điểm")]
        [Range(0.0, 10.0, ErrorMessage = "Nhập giá trị từ 0.0 - 10.0")]
        [RegularExpression(@"^\d+(\.\d{1,1})?$", ErrorMessage = "Điểm là số thực và chỉ được chứa một chữ số sau dấu chấm")]
        [Display (Name = "Điểm")]
        public float? Score{ get; set; }


        public string? AvatarUrl { get; set; }
        
    }
}