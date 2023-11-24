using AppCItas.Data;
using AppCItas.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace AppCitas.Controllers;

public class AccountController:BaseApiController
{
    private readonly DataContext _context;
    public AccountController(DataContext context) 
    {
        _context= context;
    }
    [HttpPost("register")]
    public async Task <ActionResult<AppUser>> Register(string username,string password)
    {
        using var hmac = new HMACSHA512(); //using que no está en importaciones se usa para que
                                           //cuando se libere ejecute el garbage collector

        var user = new AppUser
        {
            UserName = username,
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
            PasswordSalt = hmac.Key
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();

        return user;

    }

}
