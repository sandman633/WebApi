using BL.Interfaces.CRUD;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementations
{
    public class BaseService<TDto, TEntity> : ICrudService<TDto>
        where TDto : BaseDto
        where TEntity : BaseEntity
    {
        protected readonly ICrudRepository<TDto, TEntity> _crudRepository;

        public BaseService(ICrudRepository<TDto, TEntity> crudRepository)
        {
            _crudRepository = crudRepository;
        }
        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = await _crudRepository.CreateAsync(dto);
            return entity;
        }

        public async Task DeleteAsync(params int[] ids)
        {
            await _crudRepository.DeleteAsync(ids);
        }

        public async Task<IEnumerable<TDto>> GetAsync()
        {
            var entity = await _crudRepository.GetAsync();
            return entity;
        }

        public async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await _crudRepository.GetByIdAsync(id);
            return entity;
        }

        public async Task<TDto> UpdateAsync(TDto dto)
        {
            var entity = await _crudRepository.UpdateAsync(dto);
            return entity;
        }
    }
}
