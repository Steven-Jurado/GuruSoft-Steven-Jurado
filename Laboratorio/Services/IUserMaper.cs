using laboratorio.data.access;
using laboratorio.data.access.Context;
using Laboratorio.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<MapperResponse> AddUserGuruSoftAsync(User user)
        {
            await _contextLaboratorio.User.AddAsync(user);
            await _contextLaboratorio.SaveChangesAsync();

            return new MapperResponse() { StatusCode = 200 };

        }

        public async Task<List<User>> ListUserGuruSoftAsync()
        {
            return await _contextLaboratorio.User.ToListAsync();
        }
    }


}
