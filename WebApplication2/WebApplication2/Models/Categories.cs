using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class Categories
{
    [Key]
    public int PK_categoty { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    public IEnumerable<Products> ProductsEnumerable { get; set; }
}