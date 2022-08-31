namespace TFNetCoreASPDemo.Models
{
    public class FakeDBContext : IFakeDBContext
    {
        private List<User> users { get; set; }

        public FakeDBContext()
        {
            users = new List<User>();
            users.Add(new User { Id = 1, Email = "arthur@kaamelott.com", Nickname = "Arthur", Password = "1234" });
            users.Add(new User { Id = 2, Email = "Merlin@kaamelott.com", Nickname = "Merlin", Password = "1234" });
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }

        public void Add(User newUser)
        {
            newUser.Id = users.Max(x => x.Id) + 1;
            users.Add(newUser);
        }

        public void Delete(int id)
        {
            users.Remove(users.First(x => x.Id == id));
        }

        public void Update(User u)
        {
            users[users.FindIndex(x => x.Id == u.Id)] = u;
        }
    }
}
