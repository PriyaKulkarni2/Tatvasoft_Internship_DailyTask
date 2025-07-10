using Mission.Entities.ViewModels;
using Mission.Entities.ViewModels.Login;
using Mission.Entities.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IService
{
    public interface IUserService
    {
        
        Task<ResponseResult> LoginUser(UserLoginRequestModel model);

        Task<List<UserResponseModel>> GetUsersAsync();

        Task<bool> RegisterUserAsync(AddUserRequestModel model);

        Task<UserResponseModel?> GetLoginUserDetailById(int userId);

        Task<ResponseResult> UpdateUserAsync(UpdateUserRequestModel model);

        Task<bool> DeleteUser(int userId);
    }
}
