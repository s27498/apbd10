using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models;
[PrimaryKey(nameof(FK_account), nameof(FK_Product))]
public class Shopping_Carts
{
    public int FK_account { get; set; }
    [ForeignKey(nameof(FK_account))]
    public Accounts Accounts { get; set; }
    public int FK_Product { get; set; }
    [ForeignKey(nameof(FK_Product))]
    public Products Products { get; set; }= null!;
    
    public int Amount { get; set; }
    

}