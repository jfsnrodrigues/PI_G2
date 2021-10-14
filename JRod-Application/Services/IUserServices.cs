using JRod_Application.Models;
using System.Collections.Generic;

namespace JRod_Application.Services
{
    public interface IUserServices
    {
        User Add(User user);
        IEnumerable<User> GetAll();
        User Get(int idUser);
        User Update(User user);
        void Delete(int userId);
    }
}