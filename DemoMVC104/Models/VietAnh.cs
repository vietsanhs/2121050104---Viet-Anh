using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoMVC104.Models
{
    [Table("VietAnh")]

    public class VietAnh
    {
        
        [Key]

          public string PersonId {get; set;}

          public string FullName {get; set;}

          public string Address {get; set;}
    
          
    }
}
