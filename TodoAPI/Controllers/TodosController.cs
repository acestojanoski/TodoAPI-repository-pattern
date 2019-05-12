using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAPI.Domain.Models;
using TodoAPI.Domain.Services;
using TodoAPI.Resources;

namespace TodoAPI.Controllers
{
    [Route("/api/[controller]")]
    public class TodosController : Controller
    {
        private readonly ITodoService _todoService;
        private readonly IMapper _mapper;

        public TodosController(ITodoService todoService, IMapper mapper)
        {
            _todoService = todoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<TodoResource>> GetAllAsync ()
        {
            var todos = await _todoService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Todo>, IEnumerable<TodoResource>>(todos);

            return resources;
        }

    }
}
