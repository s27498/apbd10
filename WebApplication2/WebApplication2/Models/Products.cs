using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication2.Models;

public class Products
{
    [Key]
    public int PK_product { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    public double Weight { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    
    public IEnumerable<Shopping_Carts> CartsEnumerable { get; set; }
    public IEnumerable<Categories> CategoriesEnumerable { get; set; }
    public IEnumerable<Products_Categories> ProductsCategoriesEnumerable { get; set; }
    
}