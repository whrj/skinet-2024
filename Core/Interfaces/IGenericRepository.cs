using System;
using System.Collections.Generic;
using Core.Entities;
namespace Core.Interfaces;

public interface IGenericRepository<T> where T:BaseEntity
{
    Task<T?> GetByIdAsync(int Id);
    Task<IReadOnlyList<T>> ListAllAsync();
    
    void Add(T entity);

    void Update(T entity);

    void Remove(T entity);

    Task<bool?> SaveAllAsync(T entity);

    bool Exists(int id);
}
