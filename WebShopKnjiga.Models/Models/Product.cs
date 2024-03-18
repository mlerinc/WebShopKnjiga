using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopKnjiga.Models.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }

    public string Description { get; set; }
    [Required]

    public string ISBN { get; set; }
    [Required]

    public string Author { get; set; }
    [DisplayName("List price")]
    [Range(1, 1000)]

    public double ListPrice { get; set; }
    [Range (1, 1000)]
    public decimal Price { get; set; }
    [DisplayName("Price for 50+")]

    public double Price50 { get; set; }
    [DisplayName("Price for 100+")]

    public double Price100 { get; set; }

}
