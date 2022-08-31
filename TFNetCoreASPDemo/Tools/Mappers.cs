using ASP = TFNetCoreASPDemo.Models;
using DAL = DataAccessLayer.Entities;

namespace TFNetCoreASPDemo.Tools
{
    public static class Mappers
    {
        public static ASP.User ToData(this ASP.UserForm u)
        {
            return new ASP.User
            {
                Id = u.Id,
                Email = u.Email,
                Password = u.Password,
                Nickname = u.Nickname
            };
        }

        public static ASP.UserForm ToForm(this ASP.User u)
        {
            return new ASP.UserForm
            {
                Id = u.Id,
                Nickname = u.Nickname,
                Email = u.Email, 
                Password = u.Password
            };
        }

        public static ASP.User ToAPI(this DAL.User u)
        {
            return new ASP.User
            {
                Email = u.Email,
                Id = u.Id,
                Nickname = u.Nickname
            };
        }

        public static DAL.User ToDAL(this ASP.User u)
        {
            return new DAL.User
            {
                Email = u.Email,
                Id = u.Id,
                Nickname = u.Nickname,
                Password = u.Password
            };
        }
    }
}
