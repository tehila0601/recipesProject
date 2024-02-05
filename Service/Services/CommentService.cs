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
    //public class CommentService /*:IService<CommentDto>*/
    //{
    //    //private readonly IMapper mapper;
    //    //private readonly IRepository<Comment> repository;
    //    //public CommentService(IRepository<Comment> repository, IMapper mapper)
    //    //{
    //    //    this.repository = repository;
    //    //    this.mapper = mapper;
    //    //}
    //    //public async Task AddItemAsync(CommentDto item)
    //    //{
    //    //    await repository.AddItemAsync(mapper.Map<Comment>(item));
    //    //}

    //    //public async Task DeleteAsync(int id)
    //    //{
    //    //    await repository.DeleteAsync(id);
    //    //}

    //    //public async Task<CommentDto> GetAsyncById(int id)
    //    //{
    //    //    return mapper.Map<CommentDto>(await repository.GetAsyncById(id));
    //    //}

    //    //public async Task<List<CommentDto>> GetAllAsync()
    //    //{
    //    //    return mapper.Map<List<CommentDto>>(await repository.GetAllAsync());
    //    //}

    //    //public async Task UpdateAsync(int id, CommentDto item)
    //    //{
    //    //    await repository.UpdateAsync(id, mapper.Map<Comment>(item));
    //    //}
    //}
}
