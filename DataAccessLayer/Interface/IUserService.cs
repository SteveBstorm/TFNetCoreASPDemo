using DataAccessLayer.Entities;

namespace DataAccessLayer.Services
{
    public interface IUserService
    {
        void Create(User user);
        IEnumerable<User> GetAll();
    }
}