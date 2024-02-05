using AutoMapper;
using Common.Entity; 
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Entity;

namespace Service.Services
{
    public class CategoryService :IService <CategoryDto>
    {
        private readonly IMapper mapper;
        private readonly IRepository<Category> repository;
        public CategoryService(IRepository<Category> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task AddItemAsync(CategoryDto item)
        {
            await repository.AddItemAsync(mapper.Map<Category>(item));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<CategoryDto> GetAsyncById(int id)
        {
            return mapper.Map<CategoryDto>(await repository.GetAsyncById(id));
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            return mapper.Map<List<CategoryDto>>(await repository.GetAllAsync());
        }

        public async Task UpdateAsync(int id, CategoryDto item)
        {
            await repository.UpdateAsync(id, mapper.Map<Category>(item));
        }
    }
}
