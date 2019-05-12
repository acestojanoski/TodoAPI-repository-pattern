using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Domain.Models;

namespace TodoAPI.Domain.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<Todo>> ListAsync();
    }
}
