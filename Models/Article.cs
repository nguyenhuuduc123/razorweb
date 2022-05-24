using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// [Table("posts")]
public class Article {

    [Key]
    public int Id {set;get;}
    [StringLength(255,MinimumLength =6,ErrorMessage ="{0} phải dài từ {2} đến {1} ký tự")]
    [Required(ErrorMessage ="{0} phải nhập")]
    [Column(TypeName ="nvarchar")]
    [DisplayName("tiêu đề")]
    public string Title {set;get;}
    [DataType(DataType.Date)]
   [Required(ErrorMessage ="{0} phải nhập")]
     [DisplayName("ngày tạo")]
    public DateTime Created {set;get;}
     [Column(TypeName ="ntext")]
      [DisplayName("nội dung")]
    public string Content {set;get;}

}