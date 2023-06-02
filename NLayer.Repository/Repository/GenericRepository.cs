using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;

namespace NLayer.Repository.Repository;

public class GenericRepository<T>:IGenericRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;
    
    //constructor
    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    
    
    /// <summary>
    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        
    }
    
    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }
    
    
    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
    {
        return _dbSet.AsNoTracking().AsQueryable();
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
    {
        return _dbSet.Where(expression);
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.AnyAsync(expression);
    }
    

    
    //void function
    public void Update(T entity)
    {
       _dbSet.Update(entity);
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
    }
}