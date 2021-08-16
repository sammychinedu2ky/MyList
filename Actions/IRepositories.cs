using System.Collections.Generic;
using System.Threading.Tasks;
using MyList.Model;

namespace MyList.Actions
{
    public interface IRepository
    {
        Task CreateItemAsync(Todo item);
        Task DeleteItemAsync(int id);
        Task<Todo> GetItemAsync(int id);
        Task<IEnumerable<Todo>> GetItemsAsync();
        Task UpdateItemAsync(Todo item);
    }
}