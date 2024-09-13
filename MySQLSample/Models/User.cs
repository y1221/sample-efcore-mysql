using System.ComponentModel.DataAnnotations;

namespace MySQLSample.Models
{
    public class User
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "ユーザ名")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "20文字以下で入力してください。")]
        [Required(ErrorMessage = "必須項目です。")]
        public string Name { get; set; } = string.Empty;
    }
}
