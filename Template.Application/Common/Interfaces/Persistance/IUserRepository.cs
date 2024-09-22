using Template.Domain.Entities;

namespace Template.Application.Common.Interfaces.Persistance
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);

        void Add(User user);

    }
}
