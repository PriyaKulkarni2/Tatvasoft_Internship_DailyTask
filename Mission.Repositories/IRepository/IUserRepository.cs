using Mission.Entities.ViewModels.Login;
using Mission.Entities.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories.IRepository
{
    public interface IUserRepository
    {
        Task<List<UserResponseModel>> GetUsersAsync();
        Task<(UserLoginResponseModel? response, string message)> LoginUser(UserLoginRequestModel model);

        Task<bool> RegisterUserAsync(AddUserRequestModel model);

        Task<UserResponseModel?> GetLoginUserDetailById(int userId);

        Task<(bool response, string message)> UpdateUserAsync(UpdateUserRequestModel model);

        Task<bool> DeleteUser(int userId);
    }
}
