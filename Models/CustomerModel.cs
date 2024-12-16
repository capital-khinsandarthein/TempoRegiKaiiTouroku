using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Models
{
   public class CustomerModel
    {
        //[Required(ErrorMessage = "該当の値を入力・選択してください。")]
        [Key]
        //[MinLength(8,ErrorMessage = "このフィールドの最小長は 8。")]     
        [Column(TypeName = "varchar(10)")]
        public string CustomerCD { get; set; }

        [Required(ErrorMessage = "該当の値を入力・選択してください。")]
        //[MinLength(13, ErrorMessage = "このフィールドの最小長は 14。")]
        [Column(TypeName="varchar(14)")]      
        public string CustomerJANCD { get; set; }

        [Required(ErrorMessage = "該当の値を入力・選択してください。")]
        [RegularExpression(@"^[\u4E00-\u9FFF\u3040-\u309F\s]+$", ErrorMessage = "有効な漢字とひらがな文字を入力してください。")]
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "該当の値を入力・選択してください。")]
        [RegularExpression(@"^[\u4E00-\u9FFF\u3040-\u309F\s]+$", ErrorMessage = "有効な漢字とひらがな文字を入力してください。")]
        [Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [RegularExpression(@"^[\u4E00-\u9FFF\u3040-\u309F\s]+$", ErrorMessage = "有効な漢字とひらがな文字を入力してください。")]
        public string NameLong { get; set; }

        [Required(ErrorMessage = "該当の値を入力・選択してください。")]
        [RegularExpression(@"^[\uFF5F-\uFF9F\u30A0-\u30FF\s]+$", ErrorMessage = "有効なカタカナ文字を入力してください。")]
        [Column(TypeName = "varchar(30)")]
        public string KanaName { get; set; }

        [Column(TypeName = "varchar(40)")]
        //[RegularExpression(@"^[\u30A0-\u30FF\u3040-\u309F]+$", ErrorMessage = "hirakana and katakana")]
        public string GroupName { get; set; }

        public int  gender { get; set; }

        [Required(ErrorMessage = "該当の値を入力・選択してください。")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string BirthDate { get; set; }
      

        [Column(TypeName = "nvarchar(5)")]
        public string TelNo1 { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string TelNo2 { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string TelNo3 { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string homeTelNo1 { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string homeTelNo2 { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string homeTelNo3 { get; set; }

        [Column(TypeName = "varchar(100)")]
        [EmailAddress(ErrorMessage = "無効なメールアドレス")]
        [Display(Name = "MailAddress")]
        public string MailAddress { get; set; }

        [EmailAddress(ErrorMessage = "無効なメールアドレス")]
        [Display(Name = "MailAddress2")]
        [Column(TypeName = "varchar(100)")]
        [Compare("MailAddress", ErrorMessage = "メールアドレスは一致する必要があります。")]
        public string MailAddress2 { get; set; }

        public bool chkSend { get; set; }

        [MinLength(3, ErrorMessage = "このフィールドの最小長は 3。")]
        [Column(TypeName = "nvarchar(3)")]
        public string ZipCode1 { get; set; }

        [MinLength(4, ErrorMessage = "このフィールドの最小長は 4。")]
        public string ZipCode2 { get; set; }

        [Column(TypeName = "varchar(100)")]
        //[RegularExpression(@"^[\u30A0-\u30FF\u3040-\u309F]+$", ErrorMessage = "カタカナとひらがな")]
        public string Address1 { get; set; }

        [Column(TypeName = "varchar(100)")]
        //[RegularExpression(@"^[\u30A0-\u30FF\u3040-\u309F]+$", ErrorMessage = "カタカナとひらがな")]
        public string Address2 { get; set; }  

        public int chkSend1 { get; set; }

        public string StoreKBN { get; set; }

        public string CustomerName { get; set; }





    }

   
}
