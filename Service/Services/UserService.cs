using AutoMapper;
using Common.Entity;
using Repository.Entity;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IService<UserDto>
    {
        private readonly IMapper mapper;
        private readonly IRepository<User> repository;
        public UserService(IRepository<User> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task AddItemAsync(UserDto item)
        {
            await repository.AddItemAsync(mapper.Map<User>(item));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<UserDto> GetAsyncById(int id)
        {
            return mapper.Map<UserDto>(await repository.GetAsyncById(id));
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            return mapper.Map<List<UserDto>>(await repository.GetAllAsync());
        }

        public async Task UpdateAsync(int id, UserDto item)
        {
            await repository.UpdateAsync(id, mapper.Map<User>(item));
        }
    }
}
