using JRod_Application.Data.Repositories;
using JRod_Application.Models;
using Mapster;
using System.Collections.Generic;

namespace JRod_Application.Services
{
    public class UserServices
    {
        readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> Get()
        {
            return _userRepository.GetAll()
                .Adapt<IEnumerable<User>>();
        }

        public User Get(int idUser)
        {
            return _userRepository.Get(idUser)
                .Adapt<User>();
        }

        public User Update(User user)
        {
            Data.DataModels.User taskDb = _userRepository.Get(user.UserId);

            user.Adapt(taskDb);

            return _userRepository.Update(taskDb)
                .Adapt<User>();
        }

        public User Add(User user)
        {
            return _userRepository
                .Add(user.Adapt<Data.DataModels.User>())
                .Adapt<User>();
        }
    }
}
