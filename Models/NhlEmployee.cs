using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenHoangLong2410900048_exam.Models
{
    [Table("NhlEmployee")]
    public class NhlEmployee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Không được để trống họ tên")]
        public string NhlName { get; set; } = string.Empty;

        [Display(Name = "Giới tính")]
        public string? NhlGender { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime? NhlBirthDay { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string? NhlEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        public string? NhlPhone { get; set; }

        [Display(Name = "Trạng thái")]
        public bool NhlActive { get; set; } = true;
    }
}