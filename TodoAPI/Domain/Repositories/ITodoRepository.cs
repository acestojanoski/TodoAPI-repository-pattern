﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Domain.Models;

namespace TodoAPI.Domain.Repositories
{
    public interface ITodoRepository
    {
        Task<IEnumerable<Todo>> ListAsync();
    }
}
