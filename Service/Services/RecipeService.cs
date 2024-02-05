﻿using AutoMapper;
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
    public class RecipeService : IService<RecipeDto>
    {
        private readonly IMapper mapper;
        private readonly IRepository<Recipe> repository;
        public RecipeService(IRepository<Recipe> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task AddItemAsync(RecipeDto item)
        {

            await repository.AddItemAsync(mapper.Map<Recipe>(item));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<RecipeDto> GetAsyncById(int id)
        {
            return mapper.Map<RecipeDto>(await repository.GetAsyncById(id));
        }

        public async Task<List<RecipeDto>> GetAllAsync()
        {
            return mapper.Map<List<RecipeDto>>(await repository.GetAllAsync());
        }

        public async Task UpdateAsync(int id, RecipeDto item)
        {
            await repository.UpdateAsync(id, mapper.Map<Recipe>(item));
        }
    }
}
