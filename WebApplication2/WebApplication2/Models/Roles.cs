using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class Roles
{
    [Key]
    public int PK_role { get; set; }
    public string Name { get; set; }
    public IEnumerable<Accounts> AccountsEnumerable { get; set; }
}