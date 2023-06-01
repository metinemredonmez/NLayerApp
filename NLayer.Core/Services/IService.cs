using System.Linq.Expressions;

namespace NLayer.Core.Services;

public interface IService<T> where T : class
{
    //AYNILARINI KULLANDIK AMA DÖNĞŞ TİPLERİNDE DEĞİŞKLİKLER VAR ! 
    //ilerid product veya cateory donus tıplerı farklalsım sımdı generic oldugu ıcın aynı bıraktık
    
    // veri tabanı sorguları ve entity lerdeki sorgular için burada repositorylerimizi yazıyoruz
    //sorguyapmıyoruz sadece veri tabanına yapılacak sorguyu oluşturuyoruz, 
    Task<T> GetByIdAsync(int id);

    Task<IEnumerable<T>> GetAllAsync();
    IQueryable<T> Where(Expression<Func<T,bool>> expression);
    
    Task<bool> AnyAsync(Expression<Func<T,bool>> expression);
    Task AddAsync(T entity);
    //birden fazl kayıt için ->  nesne değil interface alıyoruz
    Task AddRangeAsync(IEnumerable<T> entities);
    //update işlemlerinde async yoktur state takip edip sadece kısa sürede olduğu içi,n async func ları yoktur => aynı şekilde remove da async yoktur 
    
    //burada serevies katmanında genricee void async yoktu ama ISeervice var veritabanı değişiklikleri için async yazmamız lazım bu bir farktır.
    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity);
    Task RemoveRangeAsync(IEnumerable<T> entities);

}