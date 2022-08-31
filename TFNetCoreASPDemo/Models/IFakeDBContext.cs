
namespace TFNetCoreASPDemo.Models
{
    public interface IFakeDBContext
    {
        void Add(User newUser);
        void Delete(int id);
        List<User> GetAll();
        User GetById(int id);
        void Update(User u);
    }
}