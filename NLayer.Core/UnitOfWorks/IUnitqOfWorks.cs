namespace NLayer.Core.UnitOfWorks;

public interface IUnitqOfWorks
{
    //bunlar implements edildiğinde dbcontext in save cahnges ve savehcange async metodlarını cagarmış olacağız! 
    Task CommitAsync();
    
    void Commit();
}