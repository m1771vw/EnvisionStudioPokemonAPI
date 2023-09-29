using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using EnvisionStudioPokemonAPI.Data;
using EnvisionStudioPokemonAPI.Models;

namespace EnvisionStudioPokemonAPI.Services
{
    public class UserService
    {
        private readonly List<User> _users;
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool IsValidUser(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null;
        }
        public bool AddUser(string username, string password)
        {
            if (_context.Users.Any(u => u.Username == username))
            {
                return false; 
            }

            string hashedPassword = HashPassword(password);

            var newUser = new User
            {
                Username = username,
                Password = hashedPassword
            };

            try
            {
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return true; 
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string HashPassword(string password)
        {
            return password; 
        }

        public string GetUserId(string username)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == username);

            if (user != null)
            {
                return user.Id.ToString(); 
            }

            return null;
        }
    } 
}
