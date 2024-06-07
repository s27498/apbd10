using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models;

public class Accounts
{
    [Key]
    public int PK_account { get; set; }
    
    
    public int FK_role { get; set; }
    [ForeignKey(nameof(FK_role))]
    public Roles Roles { get; set; }
    
    [MaxLength(50)]
    public string First_name { get; set; }
    
    [MaxLength(50)]
    public string Last_name { get; set; }
    
    [MaxLength(80)]
    public string Email { get; set; }
    
    [MaxLength(9)]
    public string? Phone { get; set; }

    public IEnumerable<Shopping_Carts> ShoppingCartsEnumerable { get; set; }
    
}