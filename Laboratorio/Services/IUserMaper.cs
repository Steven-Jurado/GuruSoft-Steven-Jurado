using laboratorio.data.access;
using laboratorio.data.access.Context;
using Laboratorio.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Laboratorio.Services
{
    public interface IUserMaper
    {

        Task<MapperResponse> AddUserGuruSoftAsync(User user);
        Task<List<User>> ListUserGuruSoftAsync();

    }

    public class UserOperation : IUserMaper

    {
        private readonly ContextLaboratorio _contextLaboratorio;

        public UserOperation(ContextLaboratorio contextLaboratorio)
        {
            _contextLaboratorio = contextLaboratorio;
        }
        /// <summary>
        /// Guardamos Usuario En Base De Datos
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<MapperResponse> AddUserGuruSoftAsync(User user)
        {
            await _contextLaboratorio.User.AddAsync(user);
            await _contextLaboratorio.SaveChangesAsync();

            return new MapperResponse() { StatusCode = 200 };

        }
        /// <summary>
        /// Listamos Usuarios
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> ListUserGuruSoftAsync()
        {
            return await _contextLaboratorio.User.ToListAsync();
        }
    }


}
