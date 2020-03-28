using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webappsdemo.Models
{
    public class Products
    {
       [Required]
       public int ProductId { get; set; }
       [Required]
       [MaxLength(length:30,ErrorMessage ="Max Length")]
       public string ProductName { get; set; }

       public string CatelogType { get; set; }

       public Dept Department { get; set; }
    }
}
