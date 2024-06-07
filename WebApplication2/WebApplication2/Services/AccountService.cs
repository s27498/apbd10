using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.Models.DTOs;

namespace WebApplication2.Services;

public class AccountService
{
    
    private readonly ApplicationContext _context;

    public AccountService(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<AccountDTO> getAccount(int id)
    {
        var info = await _context.Accounts
            .Where(a => a.PK_account == id)
            .Select(a => new AccountDTO()
            {
                First_name = a.First_name,
                Last_name = a.Last_name,
                Email = a.Email,
                Phone = a.Phone,
                Roles = a.Roles.Name,
                CartsEnumerable = a.ShoppingCartsEnumerable
                    .Select(s => new ShoppingCartDTO()
                    {
                        ProductID = s.FK_Product,
                        ProductName = s.Products.Name,
                        Amount = s.Amount
                    }).ToList()
            }).FirstOrDefaultAsync();
        
        return info;
    }
    public async Task<bool> DoesAccountExist(int id)
    {
        var possibleAccount = await _context.Accounts.FindAsync(id);
        return possibleAccount != null;
    }
}