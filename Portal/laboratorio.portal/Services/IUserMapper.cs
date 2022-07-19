using laboratorio.portal.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace laboratorio.portal.Services
{
    public interface IUserMapper
    {

        Task<MapperResponse> SaveUserAsync(UserHelper userHelper);
        Task<List<UserHelper>> ListUserAsync();

    }

    public class UserOperation : IUserMapper
    {

        private readonly IComunicator _comunicator;
        public UserOperation(IComunicator comunicator)
        {
            _comunicator = comunicator;
        }

        public async Task<List<UserHelper>> ListUserAsync()
        {
            var response = await _comunicator.Get<List<UserHelper>>("User", "listuser");

            return response;
        }

        public async Task<MapperResponse> SaveUserAsync(UserHelper userHelper)
        {

            var response = await _comunicator.Post("User", "adduser", userHelper);

            return response;
        }
    }
}
