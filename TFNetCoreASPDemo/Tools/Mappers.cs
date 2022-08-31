using TFNetCoreASPDemo.Models;

namespace TFNetCoreASPDemo.Tools
{
    public static class Mappers
    {
        public static User ToData(this UserForm u)
        {
            return new User
            {
                Id = u.Id,
                Email = u.Email,
                Password = u.Password,
                Nickname = u.Nickname
            };
        }

        public static UserForm ToForm(this User u)
        {
            return new UserForm
            {
                Id = u.Id,
                Nickname = u.Nickname,
                Email = u.Email, 
                Password = u.Password
            };
        }
    }
}
