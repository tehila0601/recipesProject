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
    public class FollowerService/* :IService<FollowerDto>*/
    {
        //private readonly IMapper mapper;
        //private readonly IRepository<Follower> repository;
        //public FollowerService(IRepository<Follower> repository, IMapper mapper)
        //{
        //    this.repository = repository;
        //    this.mapper = mapper;
        //}
        //public async Task AddItemAsync(FollowerDto item)
        //{
        //    await repository.AddItemAsync(mapper.Map<Follower>(item));
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await repository.DeleteAsync(id);
        //}

        //public async Task<FollowerDto> GetAsyncById(int id)
        //{
        //    return mapper.Map<FollowerDto>(await repository.GetAsyncById(id));
        //}

        //public async Task<List<FollowerDto>> GetAllAsync()
        //{
        //    return mapper.Map<List<FollowerDto>>(await repository.GetAllAsync());
        //}

        //public async Task UpdateAsync(int id, FollowerDto item)
        //{
        //    await repository.UpdateAsync(id, mapper.Map<Follower>(item));
        //}
    }
}
