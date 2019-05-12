using AutoMapper;
using TodoAPI.Domain.Models;
using TodoAPI.Resources;

namespace Supermarket.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Todo, TodoResource>();
        }
    }
}
