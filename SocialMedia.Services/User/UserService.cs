using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class UserService : IUserService
{
    private readonly SocialMedia_DbContext _context;
    public UserService(SocialMedia_DbContext context)
    {
        _context = context;
    }

    public async Task<bool> RegisterUserAsync(UserRegister model)
    {
        var entity = new UserEntity
        {
            Email = model.Email,
            Username = model.Username,
            DateJoined = DateTime.Now
        };

        var passwordHasher = new PasswordHasher<UserEntity>();

        entity.Password = passwordHasher.HashPassword(entity, model.Password);

        _context.Users.Add(entity);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }
    }
