using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Domain.Models;
using TodoAPI.Domain.Repositories;
using TodoAPI.Persistence.Contexts;

namespace TodoAPI.Persistence.Repositories
{
    public class TodoRepository : BaseRepository, ITodoRepository
    {
        public TodoRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Todo>> ListAsync()
        {
            return await _context.Todos.ToListAsync();
        }
    }
}
