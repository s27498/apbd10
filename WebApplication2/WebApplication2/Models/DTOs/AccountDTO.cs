namespace WebApplication2.Models.DTOs;

public class AccountDTO
{
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string Roles { get; set; }
    public IEnumerable<ShoppingCartDTO> CartsEnumerable { get; set; }
    
    
}