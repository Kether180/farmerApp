using Models;
using Microsoft.EntityFrameworkCore;
using Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Services
{
    public class UserRegistration
    {
        private readonly UserDbContext _context;

        public UserRegistration(UserDbContext context)
        {
            _context = context;
        }

        public async Task<User> RegisterUserAsync(User user)
        {
            // Logic to handle registration
            // Convert UserDto to User here
            var newUser = new User
            {
                Name = user.Name,
                Email = user.Email,
                PasswordHash = HashPassword(user.PasswordHash) // Assuming you hash the password here
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task<User> AuthenticateUser(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user != null && VerifyPasswordHash(password, user.PasswordHash))
            {
                return user;
            }

            return null;
        }

        private string HashPassword(string password)
        {
            if (password == null)
            {
                return null;
            }

            // Generate a salt and hash the password using BCrypt
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return hashedPassword;
        }

        private bool VerifyPasswordHash(string password, string storedHash)
        {
            if (password == null || storedHash == null)
            {
                return false;
            }

            return HashPassword(password) == storedHash;
        }
    }
}
