using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoMVC104.Models
{
    [Table("AnhViet")]

    public class AnhViet
    {
        
        [Key]

          public string PersonId {get; set;}

          public string FullName {get; set;}

          public string Address {get; set;}
    
          
    }
}




