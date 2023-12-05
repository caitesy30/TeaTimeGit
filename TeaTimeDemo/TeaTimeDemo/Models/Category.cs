using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeaTimeDemo.Models
{
    public class Category
    {
        [Key]
        public int Id {get; set;}
        [Required(ErrorMessage = "類別名稱未填寫")]
        [MaxLength(30)]
        [DisplayName("類別名稱")]
        public string Name { get; set;}

        [Required(ErrorMessage = "顯示順序未填寫")]
        [DisplayName("顯示順序")]
        [Range(1, 100,ErrorMessage ="輸入範圍應該要在1-100之間")]
        public int DisplayOrder { get; set;}

    }
}

