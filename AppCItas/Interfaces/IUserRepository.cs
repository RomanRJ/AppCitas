using AppCitas.DTOs;
using AppCItas.Entities;
using System.Globalization;

namespace AppCitas.Interfaces;

public interface IUserRepository
{
    Task<MemberDto> GetMemberAsync(String username);
    Task<IEnumerable<MemberDto>> GetMembersAsync();
    Task<AppUser> GetUserByIdAsync(int id);
    Task<AppUser> GetUserByUsernameAsync(string username);
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<bool> SaveAllAsync();
    void Update(AppUser user);
    
}
