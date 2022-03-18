using System.Text;
using System.Text.Json;

namespace UrbanPancake.Library
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAllItems();
        void Add(T item);
    }
}
