using Template.Application.Common.Interfaces.Persistance;
using Template.Domain.Entities;
using Template.Application.DatabaseContext;
namespace Template.Infrastructure.Persistance
{
    public class UserRepository : IUserRepository
    {
        private readonly TemplateContext _context;

        public UserRepository(TemplateContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
           using (var context = _context)
           {
                context.Users.Add(user);

                context.SaveChanges();
            }
        }

        public User? GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }
    }
}
