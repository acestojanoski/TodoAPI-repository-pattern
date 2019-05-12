using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Domain.Models;
using TodoAPI.Domain.Repositories;
using TodoAPI.Domain.Services;

namespace TodoAPI.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<IEnumerable<Todo>> ListAsync()
        {
            return await _todoRepository.ListAsync();
        }
    }
}
