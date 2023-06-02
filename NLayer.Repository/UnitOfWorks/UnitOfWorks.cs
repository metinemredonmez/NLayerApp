using NLayer.Core.UnitOfWorks;

namespace NLayer.Repository.UnitOfWorks;

public class UnitOfWorks: IUnitqOfWorks
{
    private readonly AppDbContext _context;
    
    public UnitOfWorks(AppDbContext context)
    {
        _context = context;
    }
    
 
    //async
    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
       
    }

    //not async
    public void Commit()
    {
        _context.SaveChanges();
    }
}