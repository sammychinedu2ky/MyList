using Microsoft.EntityFrameworkCore;
using MyList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyList.Actions
{
    public class Repository : IRepository
    {
        private readonly swactodoContext db;
        public Repository(swactodoContext db)
        {
            this.db = db;
        }
        public async Task<Todo> GetItemAsync(int id){
            var todo = await db.Todos.Where(e=>e.Id == id).SingleAsync();
            return todo;
        }
       
        public async Task<IEnumerable<Todo>> GetItemsAsync()
        {
            var todos = await db.Todos.ToListAsync();
            return todos;
        }

        public async Task CreateItemAsync(Todo item){
 await Task.CompletedTask;
        }

        public async Task UpdateItemAsync(Todo item){
           await Task.CompletedTask;
        }

        public async Task DeleteItemAsync(int id){
            await Task.CompletedTask;
        }
    }
}
